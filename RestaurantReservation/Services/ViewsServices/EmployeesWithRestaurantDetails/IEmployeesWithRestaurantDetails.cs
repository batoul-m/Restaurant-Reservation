using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
namespace RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository;
namespace RestaurantReservation.Services.ViewsServices.EmployeesWithRestaurantDetails
{
    public interface IEmployeesWithRestaurantDetails
    {        
        Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync();
    }
}