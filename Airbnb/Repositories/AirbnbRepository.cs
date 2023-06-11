using Airbnb.Data;
using Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Repositories
{
    public class AirbnbRepository : IAirbnbRepository
    {
        private readonly AirbnbContext _context;
        public AirbnbRepository(AirbnbContext context)
        {
            _context = context;
        }

        public void CreateReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);

            _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Location>> GetAllLocations()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<Customer> GetCustomer(string customerEmail)
        {
            return await _context.Customers.Where(customer => customer.Email.Equals(customerEmail)).FirstAsync();
        }

        public async Task<Location> GetLocation(int locationId)
        {
            return await _context.Locations.FindAsync(locationId);
        }
    }
}
