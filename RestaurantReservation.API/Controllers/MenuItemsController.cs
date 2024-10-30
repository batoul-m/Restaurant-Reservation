using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.MenuItemsServices;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly IMenuItemsService _menuItemsService;

        public MenuItemsController(IMenuItemsService menuItemsService)
        {
            _menuItemsService = menuItemsService;
        }

        // POST: api/menu-items
        [HttpPost]
        public async Task<IActionResult> CreateMenuItems([FromBody] MenuItems menuItem)
        {
            if (menuItem is null)
            {
                return BadRequest("Menu Items cannot be null.");
            }
            var createdMenuItems = await _menuItemsService.CreateMItems(menuItem);
            return CreatedAtAction(nameof(GetMenuItemsById), new { id = createdMenuItems.ItemId }, createdMenuItems);
        }

        // GET: api/Menu-items/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuItemsById(int id)
        {
            var menuItems = await _menuItemsService.GetMenuItemsById(id);
            if (menuItems is null)
            {
                return NotFound();
            }
            return Ok(menuItems);
        }

        // PUT: api/menu-items
        [HttpPut]
        public async Task<IActionResult> UpdateMenuItems([FromBody] MenuItems menuItem)
        {
            if (menuItem is null)
            {
                return BadRequest("Menu item cannot be null.");
            }
            await _menuItemsService.UpdateMItems(menuItem);
            return NoContent();
        }

        // DELETE: api/menu-items/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuItems(int id)
        {
            var menuItem = await _menuItemsService.GetItemById(id);
            if (menuItem is null)
            {
                return NotFound();
            }
            await _menuItemsService.DeleteMItems(menuItem);
            return NoContent();
        }
    }
}
