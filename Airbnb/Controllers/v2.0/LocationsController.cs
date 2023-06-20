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
    public async Task<IEnumerable<LocationDTOWithPrice>> Get(CancellationToken cancellationToken)
    {
        return (await _searchService.GetLocations(cancellationToken)).Select(location => _mapper.Map<LocationDTOWithPrice>(location));
    }
}