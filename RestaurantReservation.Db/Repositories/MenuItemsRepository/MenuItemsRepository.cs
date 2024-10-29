using RestaurantReservation.Db;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Db.Repositories.MenuItemsRepository
{
    public class MenuItemsRespositry : IMenuItemsRepository 
    {
        private readonly RestaurantReservationDbContext _context
        public MenuItemsService(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async void CreateMenuItems(MenuItems menuItem)
        {
            _context.MenuItems.Add(menuItem);
            await _context.SaveChangesAsync();
        }
        async void DeleteMenuItems(MenuItems menuItem)
        {
            var exisitingItems = IsExisitMenyItems(menuItem.ItemId);
            if (exisitingItems is not null)
            {
                _context.MenuItems.Remove(exisitingItems);
                await _context.SaveChangesAsync();
            }
        }
        async void UpdateMenuItems(MenuItems menuItem)
        {
            var existingItems = IsExisitMenyItems(menuItem.ItemId);
            if (existingItems is not null)
            {
                existingItems.Name = menuItem.Name;
                existingItems.Description = menuItem.Description;
                existingItems.Price = menuItem.Price;
                existingItems.ResturantId= menuItem.ResturantId;
                await _context.SaveChangesAsync();
            }
            
        }
        public async Task<MenuItems> IsExisitMenyItems(int ItemId)
        {
            return await _context.MenuItems.FindAsync(c => c.Id == ItemId);
        }
    }
}