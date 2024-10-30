using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repository.ViewsRepository.EmployeesWithRestaurantDetailsRepository
{
    public class EmployeesWithRestaurantDetailsRepository : IEmployeesWithRestaurantDetailsRepository
    {        
        private readonly RestaurantReservationDbContext _context;

        public EmployeesWithRestaurantDetailsRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task<List<EmployeeWithRestaurantDetails>> GetEmployeesWithRestaurantDetailsAsync()
        {
            return await _context.EmployeeWithRestaurantDetails.ToListAsync();
        }
    }
}