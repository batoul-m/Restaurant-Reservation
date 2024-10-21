using System.Collections.Generic;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationService
    {
        void CreateReservations(Reservation reservation);
        void DeleteReservations(Reservation reservation);
        void UpdateRseservations(Reservation reservation);
        Task<List<Reservation>> IReservationService.GetReservationsByCustomer(int customerId);
    }
}