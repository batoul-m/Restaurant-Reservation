using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.OrderItemsRepository
{
    public class OrderItemsRespositry : IOrderItemsRepository
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
            var existingItem = IsExisitOrderItems(item.ItemId);
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
            var existingItem = IsExisitOrderItems(item.ItemId);
            if (existingItem is not null)
            {
                _context.OrderItems.Remove(existingItem);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> IsExisitOrderItems(int orderItemsId)
        {
            return await _context.OrderItems.AnyAsync(c => c.ItemId == orderItemsId);
        }
    }
}