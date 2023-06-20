using Airbnb.Models;
using Airbnb.Models.DTO;

namespace Airbnb.Services;

public interface ISearchService
{
    public Task<IEnumerable<Location>> GetLocations(CancellationToken cancellationToken);
    public Task<UnAvailableDatesReponseDTO> GetUnAvailableDates(int locationId, CancellationToken cancellationToken);
    public Task<IEnumerable<LocationDTOWithPrice>> Search(LocationRequestDTO? locationRequest, CancellationToken cancellationToken);
}