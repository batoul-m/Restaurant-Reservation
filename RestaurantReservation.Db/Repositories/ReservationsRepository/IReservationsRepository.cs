using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.ReservationsRepository
{
    public interface IReservationsRepository
    {
        void CreateReservations(Reservation reservation);
        void DeleteReservations(Reservation reservation);
        void UpdateRseservations(Reservation reservation);
        Task<List<Reservation>> IReservationService.GetReservationsByCustomer(int customerId);
    }
}