using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ReservationsServices
{
    public class ReservationUpdate : IReservationUpdate
    {
        void IReservationUpdate.UpdateReservation(RestaurantReservationDbContext context, Reservation reservation)
        {
            var existingReservation = context.Reservations.Find(reservation.ReservationId);
            if (existingReservation is not null)
            {
                existingReservation.ReservationId = reservation.ReservationId;
                existingReservation.CustomerId = reservation.CustomerId;
                existingReservation.RestaurantId = reservation.RestaurantId;
                existingReservation.TableId= reservation.TableId;
                existingReservation.PartySize = reservation.PartySize;

            }
        }
    }
}