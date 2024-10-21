using RestaurantReservation.Db.Repositories.MenuItemsRespositry;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public class MenuItemsService : IMenuItemsService
    {
        private readonly IMenuItemsRepository _menuItemsRepository;
        public MenuItemsRespositry(IMenuItemsRepository menuItemsRepository)
        {
            _menuItemsRepository = menuItemsRepository;
        }

        async void CreateMItems(MenuItems menuItems)
        {
            await _menuItemsRepository.CreateMenuItems(menuItems);
        }

        async void DeleteMItems(MenuItems menuItems)
        {
            await _menuItemsRepository.DeleteMenuItems(menuItems);
        }

        async void UpdateMItems(MenuItems menuItems)
        {
           await _menuItemsRepository.UpdateMenuItems(menuItems);
        }
    }
}