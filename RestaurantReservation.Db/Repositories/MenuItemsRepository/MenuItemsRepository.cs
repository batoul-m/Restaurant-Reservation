using RestaurantReservation.Db;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.MenuItemsRepository
{
    public class MenuItemsRespositry : IMenuItemsRepository 
    {
        private readonly RestaurantReservationDbContext _context
        public MenuItemsRespositry(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task CreateMenuItems(MenuItems menuItem)
        {
            _context.MenuItems.Add(menuItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMenuItems(MenuItems menuItem)
        {
            var exisitingItems = GetMenyItemsById(menuItem.ItemId);
            if (exisitingItems is not null)
            {
                _context.MenuItems.Remove(exisitingItems);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateMenuItems(MenuItems menuItem)
        {
            var existingItems = GetMenyItemsById(menuItem.ItemId);
            if (existingItems is not null)
            {
                existingItems.Name = menuItem.Name;
                existingItems.Description = menuItem.Description;
                existingItems.Price = menuItem.Price;
                existingItems.ResturantId= menuItem.ResturantId;
                await _context.SaveChangesAsync();
            }           
        }

        public async Task<MenuItems> GetMenuItemsById(int ItemId)
        {
            return await _context.MenuItems.FindAsync(ItemId);
        }
    }
}