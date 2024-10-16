using RestaurantReservation.Services.EmployeesServices;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Services.EmployeesServices;
namespace RestaurantReservation.Db.Repositories.EmployeeRepository
{
    public class EmployeesRespositry : IEmployeeRepository
    {
        private readonly IEmployeeService _employeeService
        public EmployeesRespositry(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        void IEmployeeRepository.CreateEmployee(Employees employees)
        {
            _employeeService.CreateEmployee(employees);
        }

        void IEmployeeRepository.DeleteEmployee(Employees employees)
        {
            _employeeService.DeleteEmployee(employees);
        }

        void IEmployeeRepository.UpdateEmployee(Employees employees)
        {
            _employeeService.UpdateEmployee(employees);
        }
        public decimal CalculateAverageOrderAmount(int employeeId)
        {
            _employeeService.CalculateAverageOrderAmount(employeeId);
        }
    }
}