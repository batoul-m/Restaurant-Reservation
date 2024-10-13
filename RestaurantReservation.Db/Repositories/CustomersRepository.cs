using RestaurantReservation.Services.CustomerServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class CustomersRespositry : ICustomersRepository
    {
        private readonly ICreateCustomer _createCustomerService;
        private readonly IDeleteCustomer _deleteCustomerService;
        private readonly IUpdateCustomer _updateCustomerService;
        public CustomersRespositry(ICreateCustomer createCustomerService, IDeleteCustomer deleteCustomerService,IUpdateCustomer updateCustomerService)
        {
            _createCustomerService = createCustomerService;
            _deleteCustomerService = deleteCustomerService;
            _updateCustomerService = updateCustomerService;
        }
        void ICustomersRepository.CreateCustomer(Customers customer)
        {
            _createCustomerService.CreateCustomer(customer);
            
        }

        void ICustomersRepository.DeleteCustomers(Customers customer)
        {
            _deleteCustomerService.DeleteCustomers(customer);
        }

        void ICustomersRepository.UpdateCustomer(Customers customer)
        {
            _updateCustomerService.UpdateCustomer(customer);
        }
    }
}