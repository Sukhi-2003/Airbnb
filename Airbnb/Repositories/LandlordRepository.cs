using Airbnb.Data;
using Airbnb.Models;

namespace Airbnb.Repositories
{
    public class LandlordRepository : ILandlordRepository
    {
        private readonly AirbnbContext _dbContext;
        public LandlordRepository(AirbnbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Landlord> GetAll()
        {
            return _dbContext.Landlords.ToList();
        }

        public Landlord GetLandlord(int id)
        {
            return _dbContext.Landlords.Find(id);
        }
    }
}
