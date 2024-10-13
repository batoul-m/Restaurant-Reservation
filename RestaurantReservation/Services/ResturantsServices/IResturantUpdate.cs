using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IResturantUpdate
    {
        void UpdateResturant(RestaurantReservationDbContext context,Restaurants resturant);
    }
}