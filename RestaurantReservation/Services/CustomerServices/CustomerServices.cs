using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using Microsoft.EntityFrameworkCore;
namespace RestaurantReservation.Services.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        private readonly RestaurantReservationDbContext _context;
        public CustomerServices(RestaurantReservationDbContext context)
        {
            _context = context;
        }
        async void ICustomerServices.CreateCustomer(Customers customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }
        async void ICustomerServices.UpdateCustomer(Customers customer)
        {
            var existingCustomer = FindCustomer(customer);
            if (existingCustomer is not null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                await _context.SaveChangesAsync();
            }
        }
        async void ICustomerServices.DeleteCustomer(Customers customer)
        {
            var existingcustomer = FindCustomer(customer);
            if (existingcustomer is not null)
            {
                _context.Customers.Remove(existingcustomer);
               await _context.SaveChangesAsync();
            }
        }
        public bool ICustomerServices.FindCutomer(Customers customer)
        {
            return _context.Customers.Find(customer.CustomerId);
        }
    }
}
