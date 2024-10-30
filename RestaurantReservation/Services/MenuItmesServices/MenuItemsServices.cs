using RestaurantReservation.Db.Repositories.MenuItemsRespositry;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.MenuItemsServices
{
    public class MenuItemsService : IMenuItemsService
    {
        private readonly IMenuItemsRepository _menuItemsRepository;
        
        public MenuItemsService(IMenuItemsRepository menuItemsRepository)
        {
            _menuItemsRepository = menuItemsRepository;
        }

        public async Task CreateMItems(MenuItems menuItems)
        {
            await _menuItemsRepository.CreateMenuItems(menuItems);
        }

        public async Task DeleteMItems(MenuItems menuItems)
        {
            await _menuItemsRepository.DeleteMenuItems(menuItems);
        }

        public async Task UpdateMItems(MenuItems menuItems)
        {
           await _menuItemsRepository.UpdateMenuItems(menuItems);
        }

        public async Task<MenuItems> GetMenuItemsById(int id)
        {
            return await _menuItemsRepository.GetMenuItemsById(id);
        }
    }
}