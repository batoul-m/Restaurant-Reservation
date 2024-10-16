using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IRestaurantServices
    {
        void CreateRestaurant(Restaurants restaurant);
        void UpdateRestaurant(Restaurants restaurants);
        void DeleteRestaurant(Restaurants restaurants);
        bool FindRestaurant(Restaurants restaurants);
    }
}