using Airbnb.Data;
using Airbnb.Models;

namespace Airbnb.Repositories
{
    public class LocationsRepository : ILocationRepository
    {
        private readonly AirbnbContext _dbContext;
        public LocationsRepository(AirbnbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Location> GetAll()
        {
            return _dbContext.Locations.ToList();
        }

        public Location GetLocation(int id)
        {
            return _dbContext.Locations.Find(id);
        }
    }
}
