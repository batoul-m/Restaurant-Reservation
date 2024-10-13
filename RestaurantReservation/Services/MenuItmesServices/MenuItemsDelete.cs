using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public class MenuItemsDelete : IMenuItemsDelete
    {
        void IMenuItemsDelete.DeleteItems(RestaurantReservationDbContext context, int ItemId)
        {
            var exisitingItems = context.MenuItems.Find(ItemId);
            if (exisitingItems is not null)
            {
                context.MenuItems.Remove(exisitingItems);
                context.SaveChanges();
            }
        }
    }
}
