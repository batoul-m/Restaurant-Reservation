using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ViewsServices.EmployeesWithRestaurantDetails
{
    public interface IEmployeesWithRestaurantDetails
    {
        public Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync();
    }
}