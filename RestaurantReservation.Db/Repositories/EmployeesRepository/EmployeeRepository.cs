using RestaurantReservation.Db;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReservation.Db.Repositories.EmployeeRepository
{
    public class EmployeesRespositry : IEmployeeRepository
    {
        private readonly RestaurantReservationDbContext _context;
        public EmployeesRespositry(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task CreateEmployee(Employee employee);
        {
            _context.Employees.Add(employees);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployee(Employee employee)
        {
            var existingEmployee = GetEmployeeById(employee.EmployeeId);
            if(existingEmployee is not null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Position = employee.Position;
                existingEmployee.ResturantId = employee.ResturantId;
                await _context.SaveChangesAsync();                
            }
        }

        public async Task DeleteEmployee(Employee employee)
        {
            var existingEmployee = GetEmployeeById(employee.EmployeeId);
            if(existingEmployee is not null)
            {
                _context.Employees.Remove(existingEmployee);
                await _context.SaveChangesAsync();               
            }            
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _context.Employee.FindAsync(employeeId);
        }

        public async Task<List<Employees>> ListManagers()
        {
            return await _context.Employees
                .Where(e => e.Position == "Manager")
                .ToListAsync();
        }

        public async Task<decimal> CalculateAverageOrderAmount(int employeeId)
        {
            var orders = await _context.Orders
                .Where(o => o.EmployeeId == employeeId)
                .ToListAsync();

            if (!orders.Any())
            {
                return 0;
            }
            return orders.Average(o => o.TotalAmount);
        }
    }
}
