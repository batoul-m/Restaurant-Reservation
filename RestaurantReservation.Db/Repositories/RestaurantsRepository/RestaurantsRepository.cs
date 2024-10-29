using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.RestaurantsRepository
{
    public class RestaurantsRespositry : IRestaurantsRepository
    {
        private readonly RestaurantReservationDbContext _context;
        public RestaurantServices(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async void CreateRestaurant(Restaurants restaurant)
        {
            _context.Restaurants.Add(resturant);
            await _context.SaveChangesAsync();
        }
        async void UpdateRestaurant(Restaurants restaurants)
        {
            var existingResturant = IsExisitRestaurants(restaurants.RestaurantId);
            if (existingResturant is not null)
            {
                existingResturant.Name = resturant.Name;
                existingResturant.PhoneNumber = resturant.PhoneNumber;
                existingResturant.Address = resturant.Address;
                existingResturant.OpeningHour = resturant.OpeningHour;
                await _context.SaveChangesAsync();
            }
        }
        async void DeleteRestaurant(Restaurants restaurants)
        {
            var existingResturant = IsExisitRestaurants(restaurants.RestaurantId);
            if (existingResturant is not null)
            {
                _context.Restaurants.Remove(existingResturant);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Restaurants> IsExisitRestaurants(int restaurantId)
        {
            return await _context.Restaurants.FindAsync(c => c.RestaurantId == restaurantId);
        }
    }
}