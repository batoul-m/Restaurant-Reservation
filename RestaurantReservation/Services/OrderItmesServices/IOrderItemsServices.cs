using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemsService
    {
        void CreateOItems(OrderItems orderItems);
        void DeleteOItems(OrderItems orderItems);
        void UpdateOItems(OrderItems orderItems);
    }
}