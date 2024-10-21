using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
namespace RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository
{
    public class EmployeesWithRestaurantDetailsRepository : IEmployeesWithRestaurantDetailsRepository
    {        
        private readonly RestaurantReservationDbContext _context;

        public EmployeesWithRestaurantDetails(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync()
        {
            return await _context.EmployeeWithRestaurantDetails.ToListAsync();
        }
    }
}