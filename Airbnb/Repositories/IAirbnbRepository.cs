using Airbnb.Models;

namespace Airbnb.Repositories
{
    public interface IAirbnbRepository
    {
        public Task<IEnumerable<Location>> GetAllLocations();
        public Task<Location> GetLocation(int locationId);
        public Task<Customer> GetCustomer(string customerEmail);
        public Task<IEnumerable<Customer>> GetAllCustomers();
        public void CreateReservation(Reservation reservation);
    }
}
