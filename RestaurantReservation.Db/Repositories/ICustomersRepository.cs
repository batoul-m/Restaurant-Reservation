using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public interface ICustomersRepository
    {
        void CreateCustomer(Customers customer);
        void DeleteCustomers(Customers customer);
        void UpdateCustomer(Customers customer);
    }
}