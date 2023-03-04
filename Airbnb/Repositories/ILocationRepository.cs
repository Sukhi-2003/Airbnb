using Airbnb.Models;

namespace Airbnb.Repositories
{
    public interface ILocationRepository
    {
        public IEnumerable<Location> GetAll();
        public Location GetLocation(int id);
    }
}
