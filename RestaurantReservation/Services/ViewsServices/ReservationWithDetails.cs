using System.Collections;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ViewsServices
{
    public class ReservationWithDetails : IReservationWithDetails
    {
        private readonly RestaurantReservationDbContext _context;
        public ReservationWithDetails(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        public async Task<ArrayList> GetReservationsWithDetailsAsync()
        {
            var result = new ArrayList();

            var dbReservationWithDetails = await _context.ReservationWithDetails.ToListAsync();

            foreach (var item in dbReservationWithDetails)
            {
                result.Add(item); // Here, item is implicitly cast to object
            }

            return result;
        }
    }
}