using System.Collections.Generic;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationService
    {
        public Task CreateReservations(Reservation reservation);
        public Task DeleteReservations(Reservation reservation);
        public Task UpdateRseservations(Reservation reservation);
        public Task<Reservation> GetReservationsById(int reservationId);
        public Task<List<Reservation>> IReservationService.GetReservationsByCustomer(int customerId);
    }
}