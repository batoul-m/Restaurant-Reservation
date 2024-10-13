using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public class MenuItemsUpdate : IMenuItemsUpdate
    {
        public void UpdateItems(RestaurantReservationDbContext context,MenuItems menuItem)
        {
            var existingItems = context.MenuItems.Find(menuItem.ItemId);
            if (existingItems is not null)
            {
                existingItems.Name = menuItem.Name;
                existingItems.Description = menuItem.Description;
                existingItems.Price = menuItem.Price;
                existingItems.ResturantId= menuItem.ResturantId;
            }
        }
    }
}    