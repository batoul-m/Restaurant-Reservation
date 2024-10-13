using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public class OrderItemUpdate :  IOrderItemUpdate
    {
        void IOrderItemUpdate.UpdateOrderItem(RestaurantReservationDbContext context, OrderItems item)
        {
            var existingItem = context.OrderItems.Find(item.ItemId);
            if (existingItem is not null)
            {
                existingItem.OrdersId = item.OrdersId;
                existingItem.ItemId = item.ItemId;
                existingItem.Quantity = item.Quantity;
                existingItem.MenuItems = item.MenuItems;
            }
        }
    }
}