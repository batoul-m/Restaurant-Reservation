using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public class UpdateEmployee : IUpdateEmployee
    {
        void IUpdateEmployee.UpdateEmployee(RestaurantReservationDbContext context, Employees employee)
        {
            var existingEmployee = context.Employees.Find(employee.EmployeeID);
            if(existingEmployee is not null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Position = employee.Position;
                existingEmployee.ResturantId = employee.ResturantId;

                context.SaveChanges();
                
            }
        }
    }
}