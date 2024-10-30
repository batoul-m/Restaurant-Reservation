using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsService 
    {
        public Task CreateMItems(MenuItems menuItems);
        public Task DeleteMItems(MenuItems menuItems);
        public Task UpdateMItems(MenuItems menuItems);
        public Task<MenuItems> GetMenuItemsById(int id);
    }
}