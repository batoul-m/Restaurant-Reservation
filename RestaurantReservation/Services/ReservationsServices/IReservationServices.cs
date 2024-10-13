using RestaurantReservation.Db.Models;
using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetReservationsByCustomer(int customerId);
    }
}
