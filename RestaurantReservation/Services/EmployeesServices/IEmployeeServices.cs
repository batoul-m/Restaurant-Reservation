using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface IEmployeeService
    {
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        bool FindEmployee(Employee employee);
        Task<List<Employees>> ListManagers();
        decimal CalculateAverageOrderAmount(int employeeId);

    }
}
