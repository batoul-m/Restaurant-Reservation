using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationCreate
    {
        void CreateReservation(RestaurantReservationDbContext context,Reservation reservation);
    }
}