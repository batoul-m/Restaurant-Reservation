using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.CustomerServices
{
    public interface ICustomerServices
    {
        public Task CreateCustomer(Customers customer);
        public Task DeleteCustomers(Customers customer);
        public Task UpdateCustomer(Customers customer);
        public Task<Customers> GetCustomerById(int customerId);
    }
}