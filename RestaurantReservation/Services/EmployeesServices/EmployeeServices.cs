using RestaurantReservation.Db;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Services.EmployeesServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly RestaurantReservationDbContext _context;

        public EmployeeService(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public Task<List<Employees>> ListManagers()
        {
            return _context.Employees
                .Where(e => e.Position == "Manager")
                .ToListAsync();
        }

        public decimal CalculateAverageOrderAmount(int employeeId)
        {
            var orders = _context.Orders
                .Where(o => o.EmployeeId == employeeId);

            if (!orders.Any())
            {
                return 0;
            }

            return orders.Average(o => o.TotalAmount);
        }
    }
}
