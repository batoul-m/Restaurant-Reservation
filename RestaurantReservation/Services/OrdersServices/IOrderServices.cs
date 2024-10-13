using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServices
    {
        Task<List<Orders>> ListOrdersAndMenuItems(int reservationId);
        Task<List<MenuItems>> ListOrderedMenuItems(int reservationId);
    }
}
