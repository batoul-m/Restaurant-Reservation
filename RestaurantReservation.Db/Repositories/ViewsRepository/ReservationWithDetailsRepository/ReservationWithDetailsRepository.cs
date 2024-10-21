using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
namespace RestaurantReservation.Db.Repositories.ViewsRepositories.ReservationWithDetailsReposiroty
{
    public class ReservationWithDetailsReposiroty : IReservationWithDetailsReposiroty
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
                result.Add(item); 
            }

            return result;
        }
    }
}