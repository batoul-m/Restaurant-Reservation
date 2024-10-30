using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.ResturantsServices;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantServices _restaurantServices;

        public RestaurantController(IRestaurantServices restaurantServices)
        {
            _restaurantServices = restaurantServices;
        }

        // POST: api/restaurant
        [HttpPost]
        public async Task<IActionResult> CreateRestaurant([FromBody] Restaurants restaurant)
        {
            if (restaurant is null)
            {
                return BadRequest("Restaurant cannot be null.");
            }
            var createdRestaurant = await _restaurantServices.CreateRestaurant(restaurant);
            return CreatedAtAction(nameof(GetRestaurantById), new { id = createdRestaurant.restaurantsId }, createdRestaurant);
        }

        // GET: api/restaurant/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            var restaurant = await _restaurantServices.GetRestaurantsById(id);
            if (restaurant is null)
            {
                return NotFound();
            }
            return Ok(restaurant);
        }

        // PUT: api/restaurant
        [HttpPut]
        public async Task<IActionResult> UpdateRestaurant([FromBody] Restaurants restaurant)
        {
            if (restaurant is null)
            {
                return BadRequest("Restaurant cannot be null.");
            }
            await _restaurantServices.UpdateRestaurant(restaurant);
            return NoContent();
        }

        // DELETE: api/restaurant/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            var restaurant = await _restaurantServices.GetRestaurantsById(id);
            if (restaurant is null)
            {
                return NotFound();
            }
            await _restaurantServices.DeleteRestaurants(restaurant);
            return NoContent();
        }
    }
}
