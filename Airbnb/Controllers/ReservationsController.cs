using Airbnb.Models.DTO;
using Airbnb.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

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

    /// <summary>
    /// This POST method creates a reservation with the input DTO object 
    /// </summary>
    /// <param name="reservationRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>Saves a new reservation in the database</returns>
    /// <response code="200">The reservation has been succesfully completed</response>
    /// <response code="500">Internal server is not working properly</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ReservationResponseDTO> PostReservation(ReservationRequestDTO reservationRequest,CancellationToken cancellationToken)
    {
        return await _reservationService.CreateReservation(reservationRequest, cancellationToken);
    }
}