using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Db.Repositories.CustomersRepository
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly RestaurantReservationDbContext _context;
        public CustomerServices(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async void CreateCustomer(Customers customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }
        async void UpdateCustomer(Customers customer)
        {
            var existingCustomer = IsExistedCutomer(customer.CustomerId);
            if (existingCustomer is not null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                await _context.SaveChangesAsync();
            }
        }
        async void DeleteCustomer(Customers customer)
        {
            var existingcustomer = IsExistedCutomer(customer.CustomerId);
            if (existingcustomer is not null)
            {
                _context.Customers.Remove(existingcustomer);
               await _context.SaveChangesAsync();
            }
        }
        async public Task<bool> IsExistedCutomer(int customerId)
        {
            return await _context.Customers.AnyAsync(c => c.Id == customerId);
        }
    }
}
