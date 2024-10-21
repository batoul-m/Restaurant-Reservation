using RestaurantReservation.Db.Repositories.CustomersRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices;
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomersRepository _customersRepository;
        public CustomersRespositry(ICustomersRepository customersRepository)
        {
            _customersRepository = customerRepository;
        }
        async void ICustomersRepository.CreateCustomer(Customers customer)
        {
            await _customersRepository.CreateCustomer(customer);
            
        }

        async void ICustomersRepository.DeleteCustomers(Customers customer)
        {
            await _customersRepository.DeleteCustomer(customer);
        }

        async void ICustomersRepository.UpdateCustomer(Customers customer)
        {
            await _customersRepository.UpdateCustomer(customer);
        }
    }
}