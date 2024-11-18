using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.ReservationsRepository
{
    public class ReservationsRespositry : IReservationsRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public ReservationsRespositry(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task CreateReservation(Reservation reservation);
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReservation(Reservation reservation)
        {
            var existingReservation = GetReservationsById(reservation.ReservationId);
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

        public async Task DeleteReservation(Reservation reservation)
        {
            var existingReservation = GetReservationsById(reservation.ReservationId);
            if (existingReservation is not null)
            {
                _context.Reservations.Remove(existingReservation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Reservations> GetReservationsById(int reservationId)
        {
            return await _context.Reservations.FindAsync(reservationId);
        }

        public async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
        {
            return await _context.Reservations
                .Where(r => r.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
