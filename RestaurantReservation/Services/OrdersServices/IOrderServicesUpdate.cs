using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServiceUpdate
    {
        void UpdateOrder(RestaurantReservationDbContext context,Orders order);
    }
}