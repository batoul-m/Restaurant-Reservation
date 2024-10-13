using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Services.OrdersServices
{
    public class OrderService : IOrderServices 
    {
        private readonly RestaurantReservationDbContext _context;

        public OrderService(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        Task<List<Orders>> IOrderServices.ListOrdersAndMenuItems(int reservationId)
        {
            return _context.Orders
                .Where(o => o.ReservationId == reservationId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItems)
                .ToListAsync();
        }

        Task<List<MenuItems>> IOrderServices.ListOrderedMenuItems(int reservationId)
        {
            return _context.OrderItems
                .Where(oi => oi.Orders.ReservationId == reservationId)
                .Select(oi => oi.MenuItems)
                .ToListAsync();        }
    }
}
