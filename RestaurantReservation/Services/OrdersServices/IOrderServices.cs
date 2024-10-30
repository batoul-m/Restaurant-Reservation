using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServices
    {
        public Task CreateOrders(Orders orders);
        public Task DeleteOrders(Orders orders);
        public Task UpdateOrders(Orders orders);
        public Task<Orders> GetOrdersById(int id);
        public Task<List<Orders>> ListOrdersAndMenuItems(int reservationId);
        public Task<List<MenuItems>> ListOrderedMenuItems(int reservationId);
    }
}