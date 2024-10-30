using System.Threading.Tasks;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository
{
    public interface IEmployeesWithRestaurantDetailsRepository
    {    
        public Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync();
    }
}