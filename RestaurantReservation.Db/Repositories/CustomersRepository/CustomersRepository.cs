using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.CustomersRepository
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly RestaurantReservationDbContext _context;
        public CustomersRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task CreateCustomer(Customers customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customers customer)
        {
            var existingCustomer = GetCutomerById(customer.CustomerId);
            if (existingCustomer is not null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCustomer(Customers customer)
        {
            var existingcustomer = GetCutomerById(customer.CustomerId);
            if (existingcustomer is not null)
            {
                _context.Customers.Remove(existingcustomer);
               await _context.SaveChangesAsync();
            }
        }

        public async Task<Customers> GetCutomerById(int customerId)
        {
            return await _context.Customers.FindAsync(customerId);
        }
    }
}
