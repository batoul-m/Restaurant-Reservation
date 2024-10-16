using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServices
    {
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        bool FindOrder(Order order);
        Task<List<Orders>> ListOrdersAndMenuItems(int reservationId);
        Task<List<MenuItems>> ListOrderedMenuItems(int reservationId);
    }
}
