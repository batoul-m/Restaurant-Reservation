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
        async void CreateReservation(Reservation reservation);
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
        }
        async void UpdateReservation(Reservation reservation)
        {
            var existingReservation = FindReservation(reservation);
            if (existingReservation is not null)
            {
                existingReservation.ReservationId = reservation.ReservationId;
                existingReservation.CustomerId = reservation.CustomerId;
                existingReservation.RestaurantId = reservation.ResturantId;
                existingReservation.TablesId= reservation.TabelsId;
                existingReservation.PartySize = reservation.PartySize;
                await _context.SaveChangesAsync();
            }
        }
        async void DeleteReservation(Reservation reservation)
        {
            var existingReservation = FindReservation(reservation);
            if (existingReservation is not null)
            {
                _context.Reservations.Remove(existingReservation);
                await _context.SaveChangesAsync();
            }
        }
        bool FindReservation(Reservation reservation)
        {
            return _context.Reservations.Find(reservation.ReservationId);
        }
        Task<List<Reservation>> IReservationService.GetReservationsByCustomer(int customerId)
        {
            return _context.Reservations
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
