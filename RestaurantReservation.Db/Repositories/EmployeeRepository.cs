using RestaurantReservation.Services.EmployeesServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class EmployeesRespositry : IEmployeeRepository
    {
        private readonly ICreateEmployee _createService;
        private readonly IDeleteEmployee _deleteService;
        private readonly IUpdateEmployee _updateService;
        public EmployeesRespositry(ICreateEmployee createService,IDeleteEmplyee deleteService,IUpdateEmployee updateService)
        {
            _createService = createService;
            _deleteService = deleteService;
            _updateService = updateService;
        }

        void IEmployeeRepository.CreateEmployee(Employees employees)
        {
            _createService.CreateEmployee(employees);
        }

        void IEmployeeRepository.DeleteEmployee(Employees employees)
        {
            _deleteService.DeleteEmployee(employees);
        }

        void IEmployeeRepository.UpdateEmployee(Employees employees)
        {
            _updateService.UpdateEmployee(employees);
        }
    }
}