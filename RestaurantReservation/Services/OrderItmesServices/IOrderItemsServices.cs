using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemsService
    {
        public Task CreateOItems(OrderItems orderItems);
        public Task DeleteOItems(OrderItems orderItems);
        public Task UpdateOItems(OrderItems orderItems);
        public Task<OrderItems> GetOrderItemsById(int id);
    }
}