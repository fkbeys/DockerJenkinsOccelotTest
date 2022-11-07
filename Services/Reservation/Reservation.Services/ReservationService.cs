using Reservation.Infrastructure;
using Reservation.Models;

namespace Reservation.Services
{
    public class ReservationService : IReservationService
    {
        public Task<ReservationDto> GetReservationById(int id)
        {
            var reserv = new ReservationDto { reservId = 1, reservDate = DateTime.Today, reservHotelId = 2, reservName = "Reserve test" };

            return Task.FromResult(reserv);

        }
    }
}
