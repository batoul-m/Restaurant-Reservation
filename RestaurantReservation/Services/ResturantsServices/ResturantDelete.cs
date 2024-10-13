using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ResturantsServices
{
    public class ResturantDelete : IResturantDelete
    {
        void IResturantDelete.DeleteResturant(RestaurantReservationDbContext context, int resturantID)
        {
            var existingResturant = context.Restaurants.Find(resturantID);
            if (existingResturant is not null)
            {
                context.Restaurants.Remove(existingResturant);
                context.SaveChanges();
            }
        }
    }
}