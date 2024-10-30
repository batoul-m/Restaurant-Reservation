using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.OrderItemsRepository
{
    public interface IOrderItemsRepository
    {
        public Task CreateOrderItem(OrderItem item);
        public Task UpdateOrderItem(OrderItem item);
        public Task DeleteOrderItem(OrderItem item);
        public Task<OrderItems> IsExisitOrderItems(int orderItemsId);
    }
}