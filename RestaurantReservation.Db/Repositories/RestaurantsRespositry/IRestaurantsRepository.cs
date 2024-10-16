using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.RestaurantsRepository
{
    public interface IRestaurantsRepository
    {
        void CreateRestaurant(Restaurants restaurants);
        void DeleteRestaurant(Restaurants restaurants);
        void UpdateRestaurant(Restaurants restaurants);
    }
}