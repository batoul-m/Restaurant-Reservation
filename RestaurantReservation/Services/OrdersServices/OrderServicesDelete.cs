using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.OrdersServices
{
    public class OrderDelete : IOrderServiceDelete
    {
        void IOrderServiceDelete.DeleteOrder(RestaurantReservationDbContext context, int orderId)
        {
            var existingOrder = context.Orders.Find(orderId);
            if (existingOrder is not null)
            {
                context.Orders.Remove(existingOrder);
                context.SaveChanges();
            }       
        }
    }
}