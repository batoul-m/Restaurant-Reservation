using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Task<Employee> IsExisitEmployee(int employeeId);
        Task<List<Employees>> ListManagers();
        decimal CalculateAverageOrderAmount(int employeeId);

    }
}
