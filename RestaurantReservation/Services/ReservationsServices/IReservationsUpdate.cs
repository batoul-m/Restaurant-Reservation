using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationUpdate
    {
        void UpdateReservation(RestaurantReservationDbContext context,Reservation reservation);
    }
}