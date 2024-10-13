using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices
{
    public class UpdateCustomer : IUpdateCustomers
    {
        void IUpdateCustomers.UpdateCustomer(RestaurantReservationDbContext context, Customers customer)
        {
                        var existingCustomer = context.Customers.Find(customer.CustomerId);
            if (existingCustomer is not null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;

                context.SaveChanges();
            }
        }
    }
}
