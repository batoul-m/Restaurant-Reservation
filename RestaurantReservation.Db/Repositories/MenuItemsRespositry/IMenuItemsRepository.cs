using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.MenuItemsRepository
{
    public interface IMenuItemsRepository
    {
        void CreateMItems(MenuItems menuItems);
        void DeleteMItems(MenuItems menuItems);
        void UpdateMItems(MenuItems menuItems);
    }
}