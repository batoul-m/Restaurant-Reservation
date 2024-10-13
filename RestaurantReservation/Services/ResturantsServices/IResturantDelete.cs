using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IResturantDelete
    {
        void DeleteResturant(RestaurantReservationDbContext context,int resturantID);
    }
}