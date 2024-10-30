using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
using RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.ViewsServices.EmployeesWithRestaurantDetails
{
    public interface IEmployeesWithRestaurantDetails
    {        
        public Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync();
    }
}