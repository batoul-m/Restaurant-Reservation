using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
using RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository;
using system.Threading.Tasks;

namespace RestaurantReservation.Services.ViewsServices.EmployeesWithRestaurantDetails
{
    public class EmployeesWithRestaurantDetails : IEmployeesWithRestaurantDetails
    {        
        private readonly IEmployeesWithRestaurantDetailsRepository _employeesWithRestaurantDetailsRepository;

        public EmployeesWithRestaurantDetails(IEmployeesWithRestaurantDetailsRepository employeesWithRestaurantDetailsRepository)
        {
            _employeesWithRestaurantDetails = employeesWithRestaurantDetailsRepository;
        }

        public async Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync()
        {
            return await _employeesWithRestaurantDetails.GetEmployeesWithRestaurantDetailsAsync();
        }
    }
}