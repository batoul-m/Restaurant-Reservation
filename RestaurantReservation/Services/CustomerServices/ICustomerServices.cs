using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface ICustomerServices
    {
        void CreateCustomer(Customers customer);
        void DeleteCustomer(Customers customer);
        void UpdateCustomer(Customers customer);
        bool FindCutomer(Customers customer);
    }
}
