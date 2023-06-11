using Airbnb.Models;
using Airbnb.Models.DTO;
using Airbnb.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.Controllers.v2._0;

[Route("api/[controller]")]
[ApiVersion("2.0")]
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
    /// This GET method maps the retrieved Location objects into a DTO model called LocationDTO.
    /// </summary>
    /// <returns>The LocationDTO model only containing the Title, Subtitle, Description, ImageURL and LandlordAvatarURL properties of the Location model.</returns>
    /// <response code="200">The list with all the LocationDTO objects have been retrieved</response>
    /// <response code="404">The list of LocationDTO's was not found</response>
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet] 
    public async Task<IEnumerable<LocationDTOWithPrice>> Get()
    {
        return (await _searchService.GetLocations()).Select(location => _mapper.Map<LocationDTOWithPrice>(location));
    }

    /// <summary>
    /// This POST method works as a filter for the airbnb application. It filters on the following properties: 
    /// Features, Type, Rooms, MinPrice and MaxPrice.
    /// </summary>
    /// <param name="requestedLocation"></param>
    /// <returns>A list of LocationDTO that correlates with the filter specifications</returns>
    //[HttpPost("Search")]
    //public async Task<IEnumerable<LocationDTO>> Search(LocationRequestDTO requestedLocation)
    //{
    //}

    /// <summary>
    /// The GET Method searches for the most expensive location.
    /// </summary>
    /// <returns>The price of the most expensive location</returns>
    [HttpGet("GetMaxPrice")]
    public async Task<ActionResult<int>> GetMaxPrice()
    {
        var location = (await _searchService.GetLocations()).OrderByDescending(location => location.PricePerDay).First();
        return (int)location.PricePerDay;
    }

    /// <summary>
    /// This GET method gets the details of a specified location.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>The details of the requested location.</returns>
    [HttpGet("GetDetails/{id}")]
    public async Task<LocationsDetailsDTO> GetDetails(int id)
    {
        var location = (await _searchService.GetLocations()).Where(location => location.Id == id).First();
        return _mapper.Map<LocationsDetailsDTO>(location);
    }

    [HttpGet("UnAvailableDates/{locationId}")]
    public async Task<UnAvailableDatesReponseDTO> GetUnAvailableDates(int locationId)
    {
        return await _searchService.GetUnAvailableDates(locationId);
    }   
}