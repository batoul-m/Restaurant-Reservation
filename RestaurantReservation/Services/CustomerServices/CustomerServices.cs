using RestaurantReservation.Db.Repositories.CustomersRepository;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.CustomerServices;
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomerServices(ICustomersRepository customersRepository)
        {
            _customersRepository = customerRepository;
        }

        public async Task<Customers> CreateCustomer(Customers customer)
        {
            await _customersRepository.CreateCustomer(customer);           
        }

        public async Task DeleteCustomers(Customers customer)
        {
            await _customersRepository.DeleteCustomer(customer);
        }

        public async Task UpdateCustomer(Customers customer)
        {
            await _customersRepository.UpdateCustomer(customer);
        }

        public async Task GetCustomerById(int customerId)
        {
            return await _customersRepository.GetCustomerById(customerId);
        }
    }
}