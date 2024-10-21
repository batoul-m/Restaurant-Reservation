using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
namespace RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository;
namespace RestaurantReservation.Services.ViewsServices.EmployeesWithRestaurantDetails
{
    public class EmployeesWithRestaurantDetails : IEmployeesWithRestaurantDetails
    {        
        private readonly IEmployeesWithRestaurantDetailsRepository _employeesWithRestaurantDetailsRepository;

        public EmployeesWithRestaurantDetails(IEmployeesWithRestaurantDetailsRepository employeesWithRestaurantDetailsRepository)
        {
            _employeesWithRestaurantDetails = employeesWithRestaurantDetailsRepository;
        }
        async Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync()
        {
            return await _employeesWithRestaurantDetails.GetEmployeesWithRestaurantDetailsAsync();
        }
    }
}