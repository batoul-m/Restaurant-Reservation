using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServiceCreate
    {
        void CreateOrder(RestaurantReservationDbContext context,Orders order);
    }
}