using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices
{
    public class DeleteCustomer : IDeleteCustomer
    {
        void IDeleteCustomer.DeleteCustomer(RestaurantReservationDbContext context, int customerId)
        {
            var customer = context.Customers.Find(customerId);
            if (customer is not null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
    }
}
