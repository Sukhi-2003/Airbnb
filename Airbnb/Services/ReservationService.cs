using Airbnb.Models;
using Airbnb.Models.DTO;
using Airbnb.Repositories;

namespace Airbnb.Services;

public class ReservationService : IReservationService
{
    private readonly IAirbnbRepository _repository;

    public ReservationService(IAirbnbRepository repository)
    {
        _repository = repository;
    }
    public async Task<ReservationResponseDTO> CreateReservation(ReservationRequestDTO reservationRequest, CancellationToken cancellationToken)
    {
        var customer = await _repository.GetCustomer(reservationRequest.Email, cancellationToken);

        var location = await _repository.GetLocation(reservationRequest.LocationId, cancellationToken);
        Customer newCustomer;


        newCustomer = customer ?? new Customer
        {
            FirstName = reservationRequest.FirstName,
            LastName = reservationRequest.LastName,
            Email = reservationRequest.Email,
        };

        await _repository.CreateReservation(
        new Reservation
        {
            Location = location,
            Customer = customer ?? newCustomer,
            Discount = reservationRequest.Discount ?? 0.0f,
            StartDate = reservationRequest.StartDate,
            EndDate = reservationRequest.EndDate,
        },
        cancellationToken) ;

        return new ReservationResponseDTO
        {
            LocationName = location.Title,
            CustomerName = customer == null ? newCustomer.FirstName : customer.FirstName ,
            Price = location.PricePerDay,
            Discount = reservationRequest.Discount ?? 0.0f
        };
    }   
}