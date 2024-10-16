using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ResturantsServices
{
    public class RestaurantServices : IRestaurantServices
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
            var existingResturant = FindRestaurant(restaurants);
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
            var existingResturant = FindRestaurant(restaurants);
            if (existingResturant is not null)
            {
                _context.Restaurants.Remove(existingResturant);
                await _context.SaveChangesAsync();
            }
        }
        void FindRestaurant(Restaurants restaurant)
        {
            return _context.Restaurants.Find(restaurants.RestaurantId);
        }
    }
}