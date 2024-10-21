using RestaurantReservation.Db;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Db.Repositories.EmployeeRepository
{
    public class EmployeesRespositry : IEmployeeRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public EmployeeService(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async void CreateEmployee(Employee employee);
        {
            _context.Employees.Add(employees);
            await_context.SaveChangesAsync();
        }
        async void UpdateEmployee(Employee employee)
        {
            var existingEmployee = IsExisitEmployee(employee.EmployeeId);
            if(existingEmployee is not null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Position = employee.Position;
                existingEmployee.ResturantId = employee.ResturantId;
                await _context.SaveChangesAsync();
                
            }
        }
        async void DeleteEmployee(Employee employee)
        {
            var existingEmployee = IsExisitEmployee(employee.EmployeeId);
            if(existingEmployee is not null)
            {
                _context.Employees.Remove(existingEmployee);
                await_context.SaveChangesAsync();
                
            }            
        }
        public async Task<bool> IsExisitEmployee(int employeeId)
        {
            return await _context.Employee.AnyAsync(c => c.EmployeeId == employeeId);
        }
        public Task<List<Employees>> ListManagers()
        {
            return _context.Employees
                .Where(e => e.Position == "Manager")
                .ToListAsync();
        }

        public decimal CalculateAverageOrderAmount(int employeeId)
        {
            var orders = _context.Orders
                .Where(o => o.EmployeeId == employeeId);

            if (!orders.Any())
            {
                return 0;
            }

            return orders.Average(o => o.TotalAmount);
        }
    }
}
