using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsUpdate
    {
        void UpdateItems(RestaurantReservationDbContext context,MenuItems menuItem);
    }
}
