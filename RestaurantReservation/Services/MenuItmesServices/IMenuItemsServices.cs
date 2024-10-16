using RestaurantReservation.Db;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsService 
    {
        void CreateMenuItems(MenuItems menuItem);
        void DeleteMenuItems(MenuItems menuItem);
        void UpdateMenuItems(MenuItems menuItem);
        bool FindMenuItems(MenuItems menuItem);
    }
}