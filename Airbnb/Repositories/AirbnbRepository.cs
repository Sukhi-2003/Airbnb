using Airbnb.Data;
using Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Repositories;

public class AirbnbRepository : IAirbnbRepository
{
    private readonly AirbnbContext _context;
    public AirbnbRepository(AirbnbContext context)
    {
        _context = context;
    }

    public async Task CreateReservation(Reservation reservation, CancellationToken cancellationToken)
    {
        await _context.Reservations.AddAsync(reservation, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<Customer>> GetAllCustomers(CancellationToken cancellationToken)
    {
        return await _context.Customers.ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Location>> GetAllLocations(CancellationToken cancellationToken)
    {
        return await _context.Locations.ToListAsync(cancellationToken); 
    }

    public async Task<Customer> GetCustomer(string customerEmail, CancellationToken cancellationToken)
    {
           
        var customer = await _context.Customers.Where(customer => customer.Email.Equals(customerEmail)).FirstOrDefaultAsync(cancellationToken);

        if(customer == null)
        {
            return null;
        }
        else
        {
            return customer;
        }
    }

    public async Task<Location> GetLocation(int locationId, CancellationToken cancellationToken)
    {
        var location = await _context.Locations.FindAsync(locationId, cancellationToken);

        if(location == null)
        {
            return null;
        }
        else
        {
            return location;
        }
    }
}