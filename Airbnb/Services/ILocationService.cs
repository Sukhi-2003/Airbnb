using Airbnb.Models;

namespace Airbnb.Services
{
    public interface ILocationService
    {
        public IEnumerable<Location> GetAll();
        public Location GetLocation(int id);
    }
}
