using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.EmployeeService
{
    public interface IEmployeeService
    {
        public Task CreateEmployee(Employees employees);
        public Task DeleteEmployee(Employees employees);
        public Task UpdateEmployee(Employees employees);
        public Task<Employee> GetEmployeeById(int employeeId);
        public Task<decimal> CalculateAverageOrderAmount(int employeeId);
        public Task<List<Employees>> ListManagers();
    }
}