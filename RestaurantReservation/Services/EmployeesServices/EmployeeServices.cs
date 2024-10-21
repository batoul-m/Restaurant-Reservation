using RestaurantReservation.Db.Repositories.EmployeeRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices;
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesRespositry(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        async void CreateEmployee(Employees employees)
        {
            await _employeeRepository.CreateEmployee(employees);
        }

        async void DeleteEmployee(Employees employees)
        {
            await _employeeRepository.DeleteEmployee(employees);
        }

        async void UpdateEmployee(Employees employees)
        {
            await _employeeRepository.UpdateEmployee(employees);
        }
        public async decimal CalculateAverageOrderAmount(int employeeId)
        {
            await _employeeRepository.CalculateAverageOrderAmount(employeeId);
        }
    }
}