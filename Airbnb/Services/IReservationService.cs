using Airbnb.Models.DTO;

namespace Airbnb.Services;

public interface IReservationService
{
    Task<ReservationResponseDTO> CreateReservation(ReservationRequestDTO reservationRequest, CancellationToken cancellatioToken);
}