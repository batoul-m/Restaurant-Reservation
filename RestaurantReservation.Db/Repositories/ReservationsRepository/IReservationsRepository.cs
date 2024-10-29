using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.ReservationsRepository
{
    public interface IReservationsRepository
    {
        void CreateReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(Reservation reservation);
        Task<Reservations> IsExisitReservations(int reservationId);
        Task<List<Reservation>> GetReservationsByCustomer(int customerId);
    }
}
