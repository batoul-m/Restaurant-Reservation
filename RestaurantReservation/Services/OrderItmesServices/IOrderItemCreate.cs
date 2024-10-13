using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemCreate
    {
        void CreateOrderItem (RestaurantReservationDbContext context, OrderItems item);
    }
}