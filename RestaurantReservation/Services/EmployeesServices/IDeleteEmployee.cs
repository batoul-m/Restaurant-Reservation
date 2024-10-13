using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface IDeleteEmployee
    {
        void DeleteEmployee(RestaurantReservationDbContext context,int employeeId);
    }
}
