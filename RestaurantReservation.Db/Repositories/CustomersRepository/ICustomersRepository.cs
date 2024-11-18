using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Db.Repositories.CustomersRepository
{
    public interface ICustomersRepository
    {
        public Task CreateCustomer(Customers customer);
        public Task DeleteCustomer(Customers customer);
        public Task UpdateCustomer(Customers customer);
        public Task<Customers> GetCutomerById(int customerId);
    }
}
