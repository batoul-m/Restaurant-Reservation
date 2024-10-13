using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface IUpdateEmployee
    {
        void UpdateEmployee(RestaurantReservationDbContext context,Employees employee);
    }
}
