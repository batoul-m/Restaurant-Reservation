using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public class CreateEmployee :  ICreateEmployee
    {        
        void ICreateEmployee.CreateEmployee(RestaurantReservationDbContext context, Employees employees)
        {
            context.Employees.Add(employees);
            context.SaveChanges();
        }       
    }
}
