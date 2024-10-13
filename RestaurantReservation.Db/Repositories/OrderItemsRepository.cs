using RestaurantReservation.Services.OrderItemsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class OrderItemsRespositry : IOrderItemsRepository
    {
        private readonly ICreateOrderItems _createService;
        private readonly IDeleteOrderItems _deleteService;
        private readonly IUpdateOrderItems _updateService;
        public OrderItemsRespositry(ICreateOrderItems createService,IDeleteOrderItems deleteService,IUpdateOrderItems updateService)
        {
            _createService = createService;
            _deleteService = deleteService;
            _updateService = updateService;
        }

        void IOrderItemsRepository.CreateOItems(OrderItems orderItems)
        {
            _createService.CreateItems(orderItems);
        }

        void IOrderItemsRepository.DeleteOItems(OrderItems orderItems)
        {
            _deleteService.DeleteItems(orderItems);
        }

        void IOrderItemsRepository.UpdateOItems(OrderItems orderItems)
        {
            _updateService.UpdateItems(orderItems);
        }
    }
}