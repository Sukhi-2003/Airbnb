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
    public async Task<ReservationResponseDTO> CreateReservation(ReservationRequestDTO reservationRequest)
    {
        var customer = await _repository.GetCustomer(reservationRequest.Email);
        var location = await _repository.GetLocation(reservationRequest.LocationId);
        Customer newCustomer;

        if (customer == null)
        {
            newCustomer = new Customer
            {
                FirstName = reservationRequest.FirstName,
                LastName = reservationRequest.LastName,
                Email = reservationRequest.Email,
            };

            _repository.CreateReservation(
            new Reservation
            {
                Location = location,
                Customer = newCustomer,
                Discount = (float)reservationRequest.Discount,
                StartDate = reservationRequest.StartDate,
                EndDate = reservationRequest.EndDate,
            });

            return new ReservationResponseDTO
            {
                LocationName = location.Title,
                CustomerName = newCustomer.FirstName,
                Price = location.PricePerDay,
                Discount = (float)reservationRequest.Discount
            };
        }
        else
        {
            _repository.CreateReservation(
            new Reservation
            {
                Location = location,
                Customer = customer,
                Discount = (float)reservationRequest.Discount,
                StartDate = reservationRequest.StartDate,
                EndDate = reservationRequest.EndDate,
            });

            return new ReservationResponseDTO
            {
                LocationName = location.Title,
                CustomerName = customer.FirstName,
                Price = location.PricePerDay,
                Discount = (float)reservationRequest.Discount
            };
        }
    }
}