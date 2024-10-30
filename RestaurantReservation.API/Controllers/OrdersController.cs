using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.OrdersServices
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        // POST: api/order
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Orders order)
        {
            if (order is null)
            {
                return BadRequest("Order cannot be null.");
            }
            var createdOrder = await _orderServices.CreateOrders(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = createdOrder.orderId}, createdOrder);
        }

        // GET: api/order/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var order = await _orderServices.GetOrdersById(id);
            if (order is null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // PUT: api/order
        [HttpPut]
        public async Task<IActionResult> UpdateOrder([FromBody] Orders order)
        {
            if (order is null)
            {
                return BadRequest("Order cannot be null.");
            }
            await _orderServices.UpdateOrders(order);
            return NoContent();
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _orderServices.GetCustomerById(id);
            if (order is null)
            {
                return NotFound();
            }
            await _orderServices.DeleteOrders(order);
            return NoContent();
        }

        // GET: api/orders/list-orders-and-menu-items/{reservationId}
        [HttpGet("list-orders-and-menu-items/{reservationId}")]
        public async Task<IActionResult> ListOrdersAndMenuItems(int reservationId)
        {
            var ordersList = await _ordersService.ListOrdersAndMenuItems(reservationId);
            return Ok(ordersList);
        }

        // GET: api/orders/list-ordered-menu-items/{reservationId}
        [HttpGet("list-ordered-menu-items/{reservationId}")]
        public async Task<IActionResult> ListOrderedMenuItems(int reservationId)
        {
            var menuItemsList = await _ordersService.ListOrderedMenuItems(reservationId);
            return Ok(menuItemsList);
        }
    }
}
