using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
namespace RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository
{
    public interface IEmployeesWithRestaurantDetailsRepository
    {    
        Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync();
    }
}