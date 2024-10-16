using RestaurantReservation.Services.OrderItemsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.OrderItemsRepository
{
    public class OrderItemsRespositry : IOrderItemsRepository
    {
        private readonly IOrderItemsService _orderItemsService;
        public OrderItemsRespositry(IOrderItemsService orderItemsService)
        {
            _orderItemsService = orderItemsService;
        }

        void IOrderItemsRepository.CreateOItems(OrderItems orderItems)
        {
            _orderItemsService.CreateOrderItem(orderItems);
        }

        void IOrderItemsRepository.DeleteOItems(OrderItems orderItems)
        {
            _orderItemsService.DeleteOrderItem(orderItems);
        }

        void IOrderItemsRepository.UpdateOItems(OrderItems orderItems)
        {
            _orderItemsService.UpdateOrderItem(orderItems);
        }
    }
}