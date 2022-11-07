using Microsoft.AspNetCore.Mvc;
using Reservation.Infrastructure;

namespace Reservation.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetReservationById(int id)
        {
            var result = await reservationService.GetReservationById(id);
            return Ok(result);
        }

    }
}
