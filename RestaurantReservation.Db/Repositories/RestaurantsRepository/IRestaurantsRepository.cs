using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.RestaurantsRepository
{
    public interface IRestaurantsRepository
    {
        public Task CreateRestaurant(Restaurants restaurant);
        public Task UpdateRestaurant(Restaurants restaurants);
        public Task DeleteRestaurant(Restaurants restaurants);
        public Task<Restaurants> GetRestaurantsById(int restaurantId);
    }
}