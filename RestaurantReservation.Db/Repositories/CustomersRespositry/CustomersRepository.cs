using RestaurantReservation.Services.CustomerServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.CustomersRepository
{
    public class CustomersRespositry : ICustomersRepository
    {
        private readonly ICustomerServices _customerServices;
        public CustomersRespositry(ICustomerServices customerServices)
        {
            _customerServices = createCustomerService;
        }
        void ICustomersRepository.CreateCustomer(Customers customer)
        {
            _createCustomerService.CreateCustomer(customer);
            
        }

        void ICustomersRepository.DeleteCustomers(Customers customer)
        {
            _createCustomerService.DeleteCustomer(customer);
        }

        void ICustomersRepository.UpdateCustomer(Customers customer)
        {
            _createCustomerService.UpdateCustomer(customer);
        }
    }
}