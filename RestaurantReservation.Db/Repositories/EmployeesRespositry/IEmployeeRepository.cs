using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        void CreateEmployee(Employees employees);
        void DeleteEmployee(Employees employees);
        void UpdateEmployee(Employees employees);
        decimal CalculateAverageOrderAmount(int employeeId);
    }
}