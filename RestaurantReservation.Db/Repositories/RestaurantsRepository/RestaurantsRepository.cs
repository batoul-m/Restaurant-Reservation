using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.RestaurantsRepository
{
    public class RestaurantsRespositry : IRestaurantsRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public RestaurantsRespositry(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task CreateRestaurant(Restaurants restaurant)
        {
            _context.Restaurants.Add(resturant);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRestaurant(Restaurants restaurants)
        {
            var existingResturant = GetRestaurantsById(restaurants.RestaurantId);
            if (existingResturant is not null)
            {
                existingResturant.Name = resturant.Name;
                existingResturant.PhoneNumber = resturant.PhoneNumber;
                existingResturant.Address = resturant.Address;
                existingResturant.OpeningHour = resturant.OpeningHour;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteRestaurant(Restaurants restaurants)
        {
            var existingResturant = GetRestaurantsById(restaurants.RestaurantId);
            if (existingResturant is not null)
            {
                _context.Restaurants.Remove(existingResturant);
                await _context.SaveChangesAsync();
            }
        }
        
        public async Task<Restaurants> GetRestaurantsById(int restaurantId)
        {
            return await _context.Restaurants.FindAsync(restaurantId);
        }
    }
}