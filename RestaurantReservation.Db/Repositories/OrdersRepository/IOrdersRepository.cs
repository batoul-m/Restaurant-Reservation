using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.OrdersRepository
{
    public interface IOrdersRepository
    {
        public Task CreateOrder(Order order);
        public Task UpdateOrder(Order order);
        public Task DeleteOrder(Order order);
        public Task<OrderItems> GetOrderById(int OrderId);
        public Task<List<Orders>> ListOrdersAndMenuItems(int reservationId);
        public Task<List<MenuItems>> ListOrderedMenuItems(int reservationId);
    }
}
