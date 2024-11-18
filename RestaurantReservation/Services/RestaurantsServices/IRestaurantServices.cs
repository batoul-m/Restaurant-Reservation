using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IRestaurantServices
    {
        public Task CreateRestaurant(Restaurants restaurants);
        public Task DeleteRestaurant(Restaurants restaurants);
        public Task UpdateRestaurant(Restaurants restaurants);
        public Task<Restaurants> GetRestaurantsById(int id);
    }
}