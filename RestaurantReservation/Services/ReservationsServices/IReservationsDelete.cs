using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationDelete
    {
        void DeleteReservation(RestaurantReservationDbContext context,int reservationId);
    }
}