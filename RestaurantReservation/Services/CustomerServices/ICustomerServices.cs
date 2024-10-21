using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface ICustomerServices
    {
        void CreateCustomer(Customers customer);
        void DeleteCustomers(Customers customer);
        void UpdateCustomer(Customers customer);
    }
}