using RestaurantReservation.Db;
using RestaurantReservation.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.MenuItemsRepository
{
    public interface IMenuItemsRepository
    {
        public Task CreateMenuItems(MenuItems menuItem);
        public Task DeleteMenuItems(MenuItems menuItem);
        public Task UpdateMenuItems(MenuItems menuItem);
        public Task<MenuItems> GetMenyItemsById(MenuItems menuItem);
    }
}