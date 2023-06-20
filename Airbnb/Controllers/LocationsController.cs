using Microsoft.AspNetCore.Mvc;
using Airbnb.Models;
using Airbnb.Services;
using Airbnb.Models.DTO;
using AutoMapper;

namespace Airbnb.Controllers;

[Route("api/[controller]")]
[ApiVersion("1.0")]
[ApiController]
public class LocationsController : ControllerBase
{
    private readonly ISearchService _searchService;
    private readonly IMapper _mapper;
    public LocationsController(ISearchService searchService, IMapper mapper)
    {
        _searchService = searchService;
        _mapper = mapper;
    }

    /// <summary>
    /// This endpoint maps the retrieved Location objects into a DTO model called LocationDTO.
    /// </summary>
    /// <returns>The LocationDTO model only containing the Title, Subtitle, Description, ImageURL and LandlordAvatarURL properties of the Location model.</returns>
    /// <response code="200">The locations with all the LocationDTO objects have been retrieved</response>
    /// <response code="404">The locations of LocationDTO's was not found</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IEnumerable<LocationDTO>> Get(CancellationToken cancellatioToken) 
    {
        return (await _searchService.GetLocations(cancellatioToken)).Select(location => _mapper.Map<LocationDTO>(location));
    }

    /// <summary>
    ///     This endpoint uses the whole Location model. The title, subtitle and description are used in the display.
    /// </summary>
    /// <returns>All the locations available in the database in a List form</returns>
    /// <response code="200">The locations with all the Location objects have been retrieved</response>
    /// <response code="404">The locations of Locations was not found</response>
    [HttpGet("GetAll")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IEnumerable<Location>> GetAll(CancellationToken cancellationToken)
    {
        return await _searchService.GetLocations(cancellationToken);
    }

    /// <summary>
    /// This POST method works as a filter for the airbnb application. It filters on the following properties: 
    /// Features, Type, Rooms, MinPrice and MaxPrice.
    /// </summary>
    /// <param name="requestedLocation"></param>
    /// <returns>A locations of LocationDTO that correlates with the filter specifications</returns>
    /// <response code="200">The filter has been succesfully completed</response>
    /// <response code="404">No locations were found with the specified filters</response>
    [HttpPost("Search")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IEnumerable<LocationDTOWithPrice>> Search(LocationRequestDTO? locationRequest, CancellationToken cancellationToken)
    {
        return await _searchService.Search(locationRequest, cancellationToken);
    }

    /// <summary>
    /// The GET Method searches for the most expensive location.
    /// </summary>
    /// <returns>The price of the most expensive location</returns>
    /// <response code="200">The filter has been succesfully completed</response>
    /// <response code="404">No locations were found with the specified filters</response>
    [HttpGet("GetMaxPrice")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<int>> GetMaxPrice(CancellationToken cancellationToken)
    {
        var location = (await _searchService.GetLocations(cancellationToken)).OrderByDescending(location => location.PricePerDay).First();
        return (int)location.PricePerDay;
    }

    /// <summary>
    /// This GET method gets the details of a specified location.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>The details of the requested location.</returns>
    /// <response code="200">The details have been succesfully retrieved</response>
    /// <response code="404">No details were found with the given location Id</response>
    [HttpGet("GetDetails/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<LocationsDetailsDTO> GetDetails(int id, CancellationToken cancellationToken)
    {
        var location = (await _searchService.GetLocations(cancellationToken)).Where(location => location.Id == id).First();

        var mapped = _mapper.Map<LocationsDetailsDTO>(location);

        return _mapper.Map<LocationsDetailsDTO>(location);
    }

    /// <summary>
    /// This GET method gets the unavailable dates of the specified locatiom
    /// </summary>
    /// <param name="locationId"></param>
    /// <returns>The unavailable dates of the specified location in DateTime object put in a locations</returns>
    /// <response code="200">The unavailable dates have been succesfully retrieved</response>
    /// <response code="404">No unavailable dates were found with the given location Id</response>
    [HttpGet("UnAvailableDates/{locationId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<UnAvailableDatesReponseDTO> GetUnAvailableDates(int locationId, CancellationToken cancellationToken)
    {
        return await _searchService.GetUnAvailableDates(locationId, cancellationToken);
    }
} 