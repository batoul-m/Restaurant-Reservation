using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemDelete
    {
        void DeleteOrderItem (RestaurantReservationDbContext context, int itemId);
    }
}