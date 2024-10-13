using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public interface IReservationsRepository
    {
        void CreateReservations(Reservation reservation);
        void DeleteReservations(Reservation reservation);
        void UpdateRseservations(Reservation reservation);
    }
}