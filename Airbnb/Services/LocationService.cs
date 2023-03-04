using Airbnb.Models;
using Airbnb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IEnumerable<Location> GetAll()
        {
            return _locationRepository.GetAll();
        }

        public Location GetLocation(int id)
        {
            return _locationRepository.GetLocation(id);
        }
    }
}
