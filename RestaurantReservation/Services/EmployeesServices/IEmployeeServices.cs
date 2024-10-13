using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface IEmployeeService
    {
        Task<List<Employees>> ListManagers();
        decimal CalculateAverageOrderAmount(int employeeId);
    }
}
