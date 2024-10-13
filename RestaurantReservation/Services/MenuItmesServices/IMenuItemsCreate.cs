using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsCreate
    {
        void CreateItems(RestaurantReservationDbContext context,MenuItems menuItem);
    }
}
