using Airbnb.Models;

namespace Airbnb.Repositories
{
    public interface ILandlordRepository
    {
        public IEnumerable<Landlord> GetAll();
        public Landlord GetLandlord(int id);
    }
}
