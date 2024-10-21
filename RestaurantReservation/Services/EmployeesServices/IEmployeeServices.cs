using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeeService
{
    public interface IEmployeeService
    {
        void CreateEmployee(Employees employees);
        void DeleteEmployee(Employees employees);
        void UpdateEmployee(Employees employees);
        decimal CalculateAverageOrderAmount(int employeeId);
    }
}