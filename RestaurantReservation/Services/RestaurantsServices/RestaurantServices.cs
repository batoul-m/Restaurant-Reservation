using RestaurantReservation.Db.Repositories.RestaurantsRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ResturantsServices
{
    public class RestaurantServices : IRestaurantServices
    {
        private readonly IRestaurantsRepository _restaurantsRepository;
        public RestaurantsRespositry(IRestaurantsRepository restaurantsRepository)
        {
            _restaurantsRepository = restaurantsRepository;
        }

        async void CreateRestaurant(Restaurants restaurants)
        {
            await _restaurantsRepository.CreateRestaurant(restaurants);   
        }

        async void DeleteRestaurant(Restaurants restaurants)
        {
            await _restaurantsRepository.DeleteRestaurant(restaurants);
        }

        async void UpdateRestaurant(Restaurants restaurants)
        {
            await _restaurantsRepository.UpdateRestaurant(restaurants);
        }
    }
}