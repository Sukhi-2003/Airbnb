using Airbnb.Models;

namespace Airbnb.Repositories;

public interface IAirbnbRepository
{
    public Task<IEnumerable<Location>> GetAllLocations(CancellationToken cancellationToken);
    public Task<Location> GetLocation(int locationId, CancellationToken cancellationToken);
    public Task<Customer> GetCustomer(string customerEmail, CancellationToken cancellationToken);
    public Task<IEnumerable<Customer>> GetAllCustomers(CancellationToken cancellationToken);
    public Task CreateReservation(Reservation reservation, CancellationToken cancellationToken);
}