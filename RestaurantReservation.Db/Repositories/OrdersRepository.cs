using RestaurantReservation.Services.OrdersServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class OrdersRespositry : IOrdersRepository
    {
        private readonly ICreateOrder _createService;
        private readonly IDeleteOrder _deleteService;
        private readonly IUpdateOrder _updateService;
        public OrdersRespositry(ICreateEmployee createService,IDeleteOrder deleteService,IUpdateOrder updateService)
        {
            _createService = createService;
            _deleteService = deleteService;
            _updateService = updateService;
        }

        void IOrdersRepository.CreateOrders(Orders orders)
        {
            _createService.CreateOrder(orders);
        }

        void IOrdersRepository.DeleteOrders(Orders orders)
        {
            _deleteService.DeleteOrder(orders);
        }

        void IOrdersRepository.UpdateOrders(Orders orders)
        {
            _updateService.UpdateOrder(orders);
        }
    }
}