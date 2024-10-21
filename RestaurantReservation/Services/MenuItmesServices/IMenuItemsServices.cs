using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsService 
    {
        void CreateMItems(MenuItems menuItems);
        void DeleteMItems(MenuItems menuItems);
        void UpdateMItems(MenuItems menuItems);
    }
}