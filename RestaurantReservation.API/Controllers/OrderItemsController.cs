using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.OrderItemsServices;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly IOrderItemsService _orderItemsService;

        public OrderItemsController(IOrderItemsService orderItemsService)
        {
            _orderItemsService = orderItemsService;
        }

        // POST: api/Order-item
        [HttpPost]
        public async Task<IActionResult> CreateOrderItems([FromBody] OrderItems orderItems)
        {
            if (orderItems is null)
            {
                return BadRequest("Order Items cannot be null.");
            }
            var createdOrderItems = await _orderItemsService.CreateOItems(orderItems);
            return CreatedAtAction(nameof(GetOrderItemsById), new { id = OrderItems.orderItemId }, createdOrderItems);
        }

        // GET: api/Order-item/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItemsById(int id)
        {
            var OrderItems = await _orderItemsService.GetOrderItemsById(id);
            if (OrderItems is null)
            {
                return NotFound();
            }
            return Ok(OrderItems);
        }

        // PUT: api/Order-item
        [HttpPut]
        public async Task<IActionResult> UpdateOrderItems([FromBody] OrderItems orderItems)
        {
            if (orderItems is null)
            {
                return BadRequest("Order Item cannot be null.");
            }
            await _orderItemsService.UpdateOItems(orderItems);
            return NoContent();
        }

        // DELETE: api/Order-item/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItems(int id)
        {
            var OrderItems = await _orderItemsService.GetOrderItemsById(id);
            if (OrderItems is null)
            {
                return NotFound();
            }
            await _orderItemsService.DeleteOItems(OrderItems);
            return NoContent();
        }
    }
}
