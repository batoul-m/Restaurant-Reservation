using RestaurantReservation.Db;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public class MenuItemsService : IMenuItemsService 
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
            var exisitingItems = FindMenuItems(menuItem);
            if (exisitingItems is not null)
            {
                _context.MenuItems.Remove(exisitingItems);
                await _context.SaveChangesAsync();
            }
        }
        async void UpdateMenuItems(MenuItems menuItem)
        {
            var existingItems = FindMenuItems(menuItem);
            if (existingItems is not null)
            {
                existingItems.Name = menuItem.Name;
                existingItems.Description = menuItem.Description;
                existingItems.Price = menuItem.Price;
                existingItems.ResturantId= menuItem.ResturantId;
                await _context.SaveChangesAsync();
            }
            
        }
        bool FindMenuItems(MenuItems menuItem)
        {
            return _context.MenuItems.Find(menuItem.ItemId);
        }
    }
}