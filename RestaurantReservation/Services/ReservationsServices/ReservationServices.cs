using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ReservationsServices
{
    public class ReservationService : IReservationService
    {
        private readonly RestaurantReservationDbContext _context;

        public ReservationService(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        Task<List<Reservation>> IReservationService.GetReservationsByCustomer(int customerId)
        {
            return _context.Reservations
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
