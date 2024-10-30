using RestaurantReservation.Db.Repositories.OrderItemsRepository;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.OrderItemsServices
{
    public class OrderItemsServices : IOrderItemsService
    {
        private readonly IOrderItemsRepository _orderItemsRepository;

        public OrderItemsServices(IOrderItemsRepository orderItemsRepository)
        {
            _orderItemsRepository = orderItemsRepository;
        }

        public async Task CreateOItems(OrderItems orderItems)
        {
            await _orderItemsRepository.CreateOrderItem(orderItems);
        }

        public async Task DeleteOItems(OrderItems orderItems)
        {
            await _orderItemsRepository.DeleteOrderItem(orderItems);
        }

        public async Task UpdateOItems(OrderItems orderItems)
        {
            await _orderItemsRepository.UpdateOrderItem(orderItems);
        }

        public async Task<OrderItems> GetOrderItemsById(int id)
        {
            return await _orderItemsRepository.GetOrderItemsById(id); 
        }
    }
}