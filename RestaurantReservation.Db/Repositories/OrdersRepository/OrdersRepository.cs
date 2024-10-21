using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db.Repositories.OrdersRepository
{
    public class OrdersRespositry : IOrdersRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public OrderService(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }
        async void UpdateOrder(Order order)
        {
            var existingOrder = IsExisitOrder(OrderId);
            if (existingOrder is not null)
            {
                existingOrder.ReservationId = order.ReservationId;
                existingOrder.TotalAmount = order.TotalAmount;
                existingOrder.OrderDate = order.OrderDate;
                await _context.SaveChangesAsync();
            }
        }
        async void DeleteOrder(Order order)
        {
            var existingOrder = IsExisitOrder(OrderId);
            if (existingOrder is not null)
            {
                _context.Orders.Remove(existingOrder);
                await _context.SaveChangesAsync();
            } 
        }
        public async Task<bool> IsExisitOrder(int OrderId)
        {
            return await _context.OrderItems.AnyAsync(c => c.OrderId == OrderId);
        }
        Task<List<Orders>> ListOrdersAndMenuItems(int reservationId)
        {
            return _context.Orders
                .Where(o => o.ReservationId == reservationId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItems)
                .ToListAsync();
        }

        Task<List<MenuItems>> ListOrderedMenuItems(int reservationId)
        {
            return _context.OrderItems
                .Where(oi => oi.Orders.ReservationId == reservationId)
                .Select(oi => oi.MenuItems)
                .ToListAsync();     
       }
    }
}
