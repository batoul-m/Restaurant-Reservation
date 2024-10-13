using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface IUpdateCustomers
    {
        void UpdateCustomer(RestaurantReservationDbContext context,Customers customer);
    }
}
