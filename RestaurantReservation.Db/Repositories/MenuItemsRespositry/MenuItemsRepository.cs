using RestaurantReservation.Services.MenuItemsServices
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.MenuItemsRepository
{
    public class MenuItemsRespositry : IMenuItemsRepository
    {
        private readonly IMenuItemsService _menuItemsService;
        public MenuItemsRespositry(IMenuItemsService menuItemsService)
        {
            _menuItemsService = menuItemsService;
        }

        void IMenuItemsRepository.CreateMItems(MenuItems menuItems)
        {
            _menuItemsService.CreateMenuItems(menuItems);
        }

        void IMenuItemsRepository.DeleteMItems(MenuItems menuItems)
        {
            _menuItemsService.DeleteMenuItems(menuItems);
        }

        void IMenuItemsRepository.UpdateMItems(MenuItems menuItems)
        {
            _menuItemsService.UpdateMenuItems(menuItems);
        }
    }
}