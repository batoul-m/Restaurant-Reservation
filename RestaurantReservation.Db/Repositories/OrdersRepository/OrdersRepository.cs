using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.OrdersRepository
{
    public class OrdersRespositry : IOrdersRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public OrdersRespositry(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        public async Task CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrder(Order order)
        {
            var existingOrder = GetOrderById(OrderId);
            if (existingOrder is not null)
            {
                existingOrder.ReservationId = order.ReservationId;
                existingOrder.TotalAmount = order.TotalAmount;
                existingOrder.OrderDate = order.OrderDate;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteOrder(Order order)
        {
            var existingOrder = GetOrderById(OrderId);
            if (existingOrder is not null)
            {
                _context.Orders.Remove(existingOrder);
                await _context.SaveChangesAsync();
            } 
        }

        public async Task<OrderItems> GetOrderById(int OrderId)
        {
            return await _context.OrderItems.FindAsync(OrderId);
        }
        
        public async Task<List<Orders>> ListOrdersAndMenuItems(int reservationId)
        {
            return await _context.Orders
                .Where(o => o.ReservationId == reservationId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItems)
                .ToListAsync();
        }

        public async Task<List<MenuItems>> ListOrderedMenuItems(int reservationId)
        {
            return await _context.OrderItems
                .Where(oi => oi.Orders.ReservationId == reservationId)
                .Select(oi => oi.MenuItems)
                .ToListAsync();     
       }
    }
}
