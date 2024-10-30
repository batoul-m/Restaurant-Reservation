using RestaurantReservation.Db.Repositories.EmployeeRepository;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.EmployeesServices;
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task CreateEmployee(Employees employees)
        {
            await _employeeRepository.CreateEmployee(employees);
        }

        public async Task DeleteEmployee(Employees employees)
        {
            await _employeeRepository.DeleteEmployee(employees);
        }

        public async Task UpdateEmployee(Employees employees)
        {
            await _employeeRepository.UpdateEmployee(employees);
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

        public async Task<decimal> CalculateAverageOrderAmount(int employeeId)
        {
            await _employeeRepository.CalculateAverageOrderAmount(employeeId);
        }

        public async Task<List<Employees>> ListManagers()
        {
            return await _employeeRepository.ListManagers();
        }
    }
}