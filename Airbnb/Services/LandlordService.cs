using Airbnb.Models;
using Airbnb.Repositories;

namespace Airbnb.Services
{
    public class LandlordService : ILandlordService
    {
        private readonly ILandlordRepository _landlordRepository;
        public LandlordService(ILandlordRepository landlordRepository)
        {
            _landlordRepository = landlordRepository;
        }
        public IEnumerable<Landlord> GetAll()
        {
            return _landlordRepository.GetAll();
        }

        public Landlord GetLandlord(int id)
        {
            return _landlordRepository.GetLandlord(id);
        }
    }
}
