using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemUpdate
    {
        void UpdateOrderItem (RestaurantReservationDbContext context, OrderItems item);
    }
}