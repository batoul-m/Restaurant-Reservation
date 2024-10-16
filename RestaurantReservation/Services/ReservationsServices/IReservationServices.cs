using System.Collections.Generic;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationService
    {
        void CreateReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(Reservation reservation);
        bool FindReservation(Reservation reservation);
        Task<List<Reservation>> GetReservationsByCustomer(int customerId);
    }
}
