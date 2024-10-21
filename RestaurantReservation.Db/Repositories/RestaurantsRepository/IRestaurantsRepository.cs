using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.RestaurantsRepository
{
    public interface IRestaurantsRepository
    {
        void CreateRestaurant(Restaurants restaurant);
        void UpdateRestaurant(Restaurants restaurants);
        void DeleteRestaurant(Restaurants restaurants);
        Task<bool> IsExisitRestaurants(int restaurantId);
    }
}