using Airbnb.Models;
using Airbnb.Models.DTO;

namespace Airbnb.Services
{
    public interface ISearchService
    {
        public Task<IEnumerable<Location>> GetLocations();
        public Task<UnAvailableDatesReponseDTO> GetUnAvailableDates(int locationId);
    }
}
