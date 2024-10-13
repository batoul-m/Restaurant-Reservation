using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IResturantCreate
    {
        void CreateResturant(RestaurantReservationDbContext context,Restaurants resturant);
    }
}