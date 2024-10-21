using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.CustomersRepository
{
    public interface ICustomersRepository
    {
        void CreateCustomer(Customers customer);
        void DeleteCustomer(Customers customer);
        void UpdateCustomer(Customers customer);
        bool IsExixtedCutomer(int customerId);
    }
}
