using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.ResturantsServices
{
    public class RestaurantUpdate : IResturantUpdate
    {
        void IResturantUpdate.UpdateResturant(RestaurantReservationDbContext context, Restaurants resturant)
        {
            var existingResturant = context.Restaurants.Find(resturant);
            if (existingResturant is not null)
            {
                existingResturant.Name = resturant.Name;
                existingResturant.PhoneNumber = resturant.PhoneNumber;
                existingResturant.Address = resturant.Address;
                existingResturant.OpeningHour = resturant.OpeningHour;
            }
        }
    }
}