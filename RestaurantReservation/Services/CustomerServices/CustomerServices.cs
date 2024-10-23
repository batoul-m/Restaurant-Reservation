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
        async void CreateCustomer(Customers customer)
        {
            await _customersRepository.CreateCustomer(customer);
            
        }

        async void DeleteCustomers(Customers customer)
        {
            await _customersRepository.DeleteCustomer(customer);
        }

        async void UpdateCustomer(Customers customer)
        {
            await _customersRepository.UpdateCustomer(customer);
        }
    }
}