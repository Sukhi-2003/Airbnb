using Airbnb.Models;

namespace Airbnb.Services
{
    public interface ILandlordService
    {
        public IEnumerable<Landlord> GetAll();
        public Landlord GetLandlord(int id);
    }
}
