using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServiceDelete
    {
        void DeleteOrder(RestaurantReservationDbContext context,int orderId);
    }
}