using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.EmployeeServices;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // POST: api/employee
        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] Employees employee)
        {
            if (employee is null)
            {
                return BadRequest("Employee cannot be null.");
            }
            var createdEmployee = await _employeeService.CreateEmployee(employee);
            return CreatedAtAction(nameof(GetEmplyeeById), new { id = createdEmployee.EmployeeId }, createdEmployee);
        }

        // GET: api/employee/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // PUT: api/employee
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee([FromBody] Employees employee)
        {
            if (employee is null)
            {
                return BadRequest("Employee cannot be null.");
            }
            await _employeeService.UpdateEmployee(employee);
            return NoContent();
        }

        // DELETE: api/employee/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emplyee = await _employeeService.GetEmployeeById(id);
            if (emplyee is null)
            {
                return NotFound();
            }
            await _employeeService.DeleteEmployee(emplyee);
            return NoContent();
        }

        // GET: api/employees/{employeeId}/average-order-amount
        [HttpGet("{employeeId}/average-order-amount}")]
        public async Task<IActionResult> CalculateAverageOrderAmount(int employeeId)
        {
            var employee = await _employeeService.GetEmployeeById(employeeId);
            if (employee is null)
            {
                return NotFound();
            }
            var averageOrderAmount = await _employeeService.CalculateAverageOrderAmount(employeeId);
            return Ok(averageOrderAmount);
        }

        // GET: api/employees/managers
        [HttpGet("managers")]
        public async Task<IActionResult> ListManagers()
        {
            var managers = await _employeeService.GetManagers();
            if( managers is null || managers.Count == 0)
            {
                return NotFound("No manager found");
            }
            return Ok(managers);
        }
    }
}
