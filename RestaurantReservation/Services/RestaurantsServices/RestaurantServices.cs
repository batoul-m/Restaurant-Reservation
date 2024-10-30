using RestaurantReservation.Db.Repositories.RestaurantsRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ResturantsServices
{
    public class RestaurantServices : IRestaurantServices
    {
        private readonly IRestaurantsRepository _restaurantsRepository;

        public RestaurantServices(IRestaurantsRepository restaurantsRepository)
        {
            _restaurantsRepository = restaurantsRepository;
        }

        public async Task CreateRestaurant(Restaurants restaurants)
        {
            await _restaurantsRepository.CreateRestaurant(restaurants);   
        }

        public async Task DeleteRestaurant(Restaurants restaurants)
        {
            await _restaurantsRepository.DeleteRestaurant(restaurants);
        }

        public async Task UpdateRestaurant(Restaurants restaurants)
        {
            await _restaurantsRepository.UpdateRestaurant(restaurants);
        }

        public async Task<Restaurants> GetRestaurantsById(int id)
        {
            return await _restaurantsRepository.GetRestaurantsById(id);
        }
    }
}