using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface ICreateEmployee
    {
        void CreateEmployee(RestaurantReservationDbContext context,Employees employees);
    }
}
