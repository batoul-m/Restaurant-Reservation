using RestaurantReservation.Db.Repositories.OrderItemsRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public class OrderItemsServices : IOrderItemsService
    {
        private readonly IOrderItemsRepository _orderItemsRepository;
        public OrderItemsRespositry(IOrderItemsRepository orderItemsRepository)
        {
            _orderItemsRepository = orderItemsRepository;
        }

        async void reateOItems(OrderItems orderItems)
        {
            await _orderItemsRepository.CreateOrderItem(orderItems);
        }

        async void DeleteOItems(OrderItems orderItems)
        {
            await _orderItemsRepository.DeleteOrderItem(orderItems);
        }

        async void UpdateOItems(OrderItems orderItems)
        {
            await _orderItemsRepository.UpdateOrderItem(orderItems);
        }
    }
}