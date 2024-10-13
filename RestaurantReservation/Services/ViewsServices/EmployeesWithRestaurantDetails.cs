using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ViewsServices
{
    public class EmployeesWithRestaurantDetails : IEmployeesWithRestaurantDetails
    {        
        private readonly RestaurantReservationDbContext _context;

        public EmployeesWithRestaurantDetails(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async Task<List<EmployeeWithRestaurantDetails>> IEmployeesWithRestaurantDetails.GetEmployeesWithRestaurantDetailsAsync()
        {
            return await _context.EmployeeWithRestaurantDetails.ToListAsync();
        }
    }
}