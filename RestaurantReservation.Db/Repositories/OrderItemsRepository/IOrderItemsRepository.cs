using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.OrderItemsRepository
{
    public interface IOrderItemsRepository
    {
        void CreateOrderItem(OrderItem item);
        void UpdateOrderItem(OrderItem item);
        void DeleteOrderItem(OrderItem item);
        Task<bool> IsExisitOrderItems(int orderItemsId);
    }
}