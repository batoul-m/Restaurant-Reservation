using RestaurantReservation.Services.RestaurantsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class RestaurantsRespositry : IRestaurantsRepository
    {
        private readonly ICreateRestaurants _createService;
        private readonly IDeleteRestaurants _deleteService;
        private readonly IUpdateRestaurants _updateService;
        public RestaurantsRespositry(ICreateRestaurants createService,IDeleteRestaurants deleteService,IUpdateRestaurants updateService)
        {
            _createService = createService;
            _deleteService = deleteService;
            _updateService = updateService;
        }

        void IRestaurantsRepository.CreateRestaurant(Restaurants restaurants)
        {
            _createService.CreateRestaurant(restaurants);   
        }

        void IRestaurantsRepository.DeleteRestaurant(Restaurants restaurants)
        {
            _deleteService.DeleteRestaurant(restaurants);
        }

        void IRestaurantsRepository.UpdateRestaurant(Restaurants restaurants)
        {
            _updateService.UpdateRestaurant(restaurants);
        }
    }
}