using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemsService
    {
        void CreateOrderItem(OrderItem item);
        void UpdateOrderItem(OrderItem item);
        void DeleteOrderItem(OrderItem item);
        bool FindOrderItem(OrderItem item);
    }
}