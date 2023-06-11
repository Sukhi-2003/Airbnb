using Airbnb.Models;
using Airbnb.Models.DTO;
using Airbnb.Repositories;

namespace Airbnb.Services
{
    public class SearchService : ISearchService
    {
        private readonly IAirbnbRepository _repository;
        public SearchService(IAirbnbRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await _repository.GetAllLocations();
        }

        public async Task<UnAvailableDatesReponseDTO> GetUnAvailableDates(int locationId)
        {
            var location = (await _repository.GetLocation(locationId));

            var unAvailableDates = new UnAvailableDatesReponseDTO();

            foreach (var reservation in location.Reservations)
            {
                unAvailableDates.UnAvailableDates.AddRange(GetDatesBetween(reservation.StartDate, reservation.EndDate));
            }

            return unAvailableDates;
        }

        public List<DateTime> GetDatesBetween(DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDates = new();

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                allDates.Add(date);
            }
                
            return allDates;
        }
    }
}
