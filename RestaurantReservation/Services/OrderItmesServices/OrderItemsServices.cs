using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public class OrderItemsServices : IOrderItemsService
    {
        private readonly RestaurantReservationDbContext _context;
        public OrderItemsServices(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async void CreateOrderItem(OrderItem item)
        {
            _context.OrderItems.Add(item);
            await _context.SaveChangesAsync();
        }
        async void UpdateOrderItem(OrderItem item)
        {
            var existingItem = FindOrderItem(item);
            if (existingItem is not null)
            {
                existingItem.OrdersId = item.OrdersId;
                existingItem.ItemId = item.ItemId;
                existingItem.Quantity = item.Quantity;
                existingItem.MenuItems = item.MenuItems;
                await _context.SaveChangesAsync();
            }
            
        }
        async void DeleteOrderItem(OrderItem item)
        {
            var existingItem = FindOrderItem(item);
            if (existingItem is not null)
            {
                _context.OrderItems.Remove(existingItem);
                await _context.SaveChangesAsync();
            }
        }
        bool FindOrderItem(OrderItem item)
        {
            return _context.OrderItems.Find(item.ItemId);
        }
    }
}