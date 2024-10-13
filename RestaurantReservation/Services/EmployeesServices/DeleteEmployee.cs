using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.EmployeesServices
{
    public class DeleteEmployee : IDeleteEmployee
    {
        void IDeleteEmployee.DeleteEmployee(RestaurantReservationDbContext context, int employeeId)
        {
            var employee = context.Employees.Find(employeeId);
            if(employee is not null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                
            }
        }
    }
}