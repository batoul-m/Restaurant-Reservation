using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.OrderItemsRepository
{
    public class OrderItemsRespositry : IOrderItemsRepository
    {
        private readonly RestaurantReservationDbContext _context;
        public OrderItemsRespositry(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task CreateOrderItem(OrderItem item)
        {
            _context.OrderItems.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderItem(OrderItem item)
        {
            var existingItem = GetOrderItemsById(item.ItemId);
            if (existingItem is not null)
            {
                existingItem.OrdersId = item.OrdersId;
                existingItem.ItemId = item.ItemId;
                existingItem.Quantity = item.Quantity;
                existingItem.MenuItems = item.MenuItems;
                await _context.SaveChangesAsync();
            }            
        }

        public async Task DeleteOrderItem(OrderItem item)
        {
            var existingItem = GetOrderItemsById(item.ItemId);
            if (existingItem is not null)
            {
                _context.OrderItems.Remove(existingItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<OrderItems> GetOrderItemsById(int orderItemsId)
        {
            return await _context.OrderItems.FindAsync(orderItemsId);
        }
    }
}