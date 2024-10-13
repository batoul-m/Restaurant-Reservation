using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationDelete
    {
        void DeleteReservation(RestaurantReservationDbContext context,int reservationId);
    }
}