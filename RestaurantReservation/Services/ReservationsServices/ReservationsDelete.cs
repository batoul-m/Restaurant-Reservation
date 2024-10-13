using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ReservationsServices
{
    public class ReservationDelete : IReservationDelete
    {
        void IReservationDelete.DeleteReservation(RestaurantReservationDbContext context, int reservationId)
        {
            var existingReservation = context.Reservations.Find(reservationId);
            if (existingReservation is not null)
            {
                context.Reservations.Remove(existingReservation);
                context.SaveChanges();
            }
        }
    }
}