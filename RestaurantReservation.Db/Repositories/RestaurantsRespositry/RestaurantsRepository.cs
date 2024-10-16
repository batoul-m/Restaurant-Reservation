using RestaurantReservation.Services.RestaurantsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.RestaurantsRepository
{
    public class RestaurantsRespositry : IRestaurantsRepository
    {
        private readonly IRestaurantServices _restaurantServices;
        public RestaurantsRespositry(IRestaurantServices restaurantServices)
        {
            _restaurantServices = restaurantServices;
        }

        void IRestaurantsRepository.CreateRestaurant(Restaurants restaurants)
        {
            _restaurantServices.CreateRestaurant(restaurants);   
        }

        void IRestaurantsRepository.DeleteRestaurant(Restaurants restaurants)
        {
            _restaurantServices.DeleteRestaurant(restaurants);
        }

        void IRestaurantsRepository.UpdateRestaurant(Restaurants restaurants)
        {
            _restaurantServices.UpdateRestaurant(restaurants);
        }
    }
}