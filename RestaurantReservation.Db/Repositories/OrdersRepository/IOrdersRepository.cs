using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.OrdersRepository
{
    public interface IOrdersRepository
    {
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        Task<bool> IsExisitOrder(int OrderId);
        Task<List<Orders>> ListOrdersAndMenuItems(int reservationId);
        Task<List<MenuItems>> ListOrderedMenuItems(int reservationId);
    }
}
