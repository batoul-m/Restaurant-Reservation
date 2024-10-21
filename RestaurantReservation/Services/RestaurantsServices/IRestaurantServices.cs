using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IRestaurantServices
    {
        void CreateRestaurant(Restaurants restaurants);
        void DeleteRestaurant(Restaurants restaurants);
        void UpdateRestaurant(Restaurants restaurants);
    }
}