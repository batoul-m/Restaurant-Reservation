using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.ReservationsRepository
{
    public interface IReservationsRepository
    {
        public Task CreateReservation(Reservation reservation);
        public Task UpdateReservation(Reservation reservation);
        public Task DeleteReservation(Reservation reservation);
        public Task<Reservations> GetReservationsById(int reservationId);
        public Task<List<Reservation>> GetReservationsByCustomer(int customerId);
    }
}
