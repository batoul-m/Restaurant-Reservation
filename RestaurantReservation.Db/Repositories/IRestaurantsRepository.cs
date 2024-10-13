using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public interface IRestaurantsRepository
    {
        void CreateRestaurant(Restaurants restaurants);
        void DeleteRestaurant(Restaurants restaurants);
        void UpdateRestaurant(Restaurants restaurants);
    }
}