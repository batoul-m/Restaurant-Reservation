using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Db.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        public Task CreateEmployee(Employee employee);
        public Task UpdateEmployee(Employee employee);
        public Task DeleteEmployee(Employee employee);
        public Task<Employee> GetEmployeeById(int employeeId);
        public Task<List<Employees>> ListManagers();
        public <decimal> CalculateAverageOrderAmount(int employeeId);
    }
}
