using RestaurantReservation.Db;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Db.Repositories.MenuItemsRepository
{
    public interface IMenuItemsRepository
    {
        void CreateMenuItems(MenuItems menuItem);
        void DeleteMenuItems(MenuItems menuItem);
        void UpdateMenuItems(MenuItems menuItem);
        Task<bool> IsExisitMenyItems(MenuItems menuItem);
    }
}