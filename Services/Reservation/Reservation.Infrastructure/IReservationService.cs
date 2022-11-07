using Reservation.Models;

namespace Reservation.Infrastructure
{
    public interface IReservationService
    {
        public Task<ReservationDto> GetReservationById(int id);

    }
}
