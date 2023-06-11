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
    /// <response code="200">The list with all the LocationDTO objects have been retrieved</response>
    /// <response code="404">The list of LocationDTO's was not found</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IEnumerable<LocationDTO>> Get() 
    {
        return (await _searchService.GetLocations()).Select(location => _mapper.Map<LocationDTO>(location));
    }

    /// <summary>
    ///     This endpoint uses the whole Location model. The title, subtitle and description are used in the display.
    /// </summary>
    /// <returns>All the locations available in the database in a List form</returns>
    /// <response code="200">The list with all the Location objects have been retrieved</response>
    /// <response code="404">The list of Locations was not found</response>
    [HttpGet("GetAll")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IEnumerable<Location>> GetAll()
    {
        return await _searchService.GetLocations();
    }
}