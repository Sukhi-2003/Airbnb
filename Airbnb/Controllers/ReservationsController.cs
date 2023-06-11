using Airbnb.Models.DTO;
using Airbnb.Services;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.Controllers;

[Route("api/[controller]")]
[ApiVersion("1.0")]
[ApiController]

public class ReservationsController : ControllerBase
{
    private IReservationService _reservationService;
    public ReservationsController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpPost]
    public async Task<ReservationResponseDTO> PostReservation(ReservationRequestDTO reservationRequest)
    {
        return await _reservationService.CreateReservation(reservationRequest);
    }
}