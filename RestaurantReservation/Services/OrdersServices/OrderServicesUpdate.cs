using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.OrdersServices
{
    public class OrderUpdate :  IOrderServiceUpdate
    {
        void IOrderServiceUpdate.UpdateOrder(RestaurantReservationDbContext context, Orders order)
        {
            var existingOrder = context.Orders.Find(order.OrderId);
            if (existingOrder is not null)
            {
                existingOrder.ReservationId = order.ReservationId;
                existingOrder.TotalAmount = order.TotalAmount;
                existingOrder.OrderDate = order.OrderDate;
            }
        }
    }
}