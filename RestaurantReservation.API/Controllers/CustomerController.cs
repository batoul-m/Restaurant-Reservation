using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.CustomerServices;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        // POST: api/customer
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customers customer)
        {
            if (customer is null)
            {
                return BadRequest("Customer cannot be null.");
            }
            var createdCustomer = await _customerServices.CreateCustomer(customer);
            return CreatedAtAction(nameof(GetCustomerById), new { id = createdCustomer.CustomerId }, createdCustomer);
        }

        // GET: api/customer/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerServices.GetCustomerById(id);
            if (customer is null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // PUT: api/customer
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer([FromBody] Customers customer)
        {
            if (customer is null)
            {
                return BadRequest("Customer cannot be null.");
            }
            await _customerServices.UpdateCustomer(customer);
            return NoContent();
        }

        // DELETE: api/customer/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _customerServices.GetCustomerById(id);
            if (customer is null)
            {
                return NotFound();
            }
            await _customerServices.DeleteCustomers(customer);
            return NoContent();
        }
    }
}
