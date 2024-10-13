using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public class MenuItemsCreate : IMenuItemsCreate
    {
        void IMenuItemsCreate.CreateItems(RestaurantReservationDbContext context, MenuItems menuItem)
        {
            context.MenuItems.Add(menuItem);
            context.SaveChanges();
        }
    }
}
