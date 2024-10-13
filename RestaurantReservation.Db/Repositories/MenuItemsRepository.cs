using RestaurantReservation.Services.MenuItemsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class MenuItemsRespositry : IMenuItemsRepository
    {
        private readonly ICreateMenuItems _createService;
        private readonly IDeleteMenuItems _deleteService;
        private readonly IUpdateMenuItems _updateService;
        public MenuItemsRespositry(ICreateMenuItems createService,IDeleteMenuItems deleteService,IUpdateMenuItems updateService)
        {
            _createService = createService;
            _deleteService = deleteService;
            _updateService = updateService;
        }

        void IMenuItemsRepository.CreateMItems(MenuItems menuItems)
        {
            _createService.CreateItems(menuItems);
        }

        void IMenuItemsRepository.DeleteMItems(MenuItems menuItems)
        {
            _deleteService.DeleteItems(menuItems);
        }

        void IMenuItemsRepository.UpdateMItems(MenuItems menuItems)
        {
            _updateService.UpdateItems(menuItems);
        }
    }
}