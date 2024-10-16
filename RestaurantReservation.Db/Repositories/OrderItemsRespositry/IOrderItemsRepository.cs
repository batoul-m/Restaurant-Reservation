using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.OrderItemsRepository
{
    public interface IOrderItemsRepository
    {
        void CreateOItems(OrderItems orderItems);
        void DeleteOItems(OrderItems orderItems);
        void UpdateOItems(OrderItems orderItems);
    }
}