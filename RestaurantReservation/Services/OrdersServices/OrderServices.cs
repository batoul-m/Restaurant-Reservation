using RestaurantReservation.Db.Repositories.OrdersRepository;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.OrdersServices
{
    public class OrderService : IOrderServices 
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrderService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task CreateOrders(Orders orders)
        {
            await _ordersRepository.CreateOrder(orders);
        }

        public async Task DeleteOrders(Orders orders)
        {
            await _ordersRepository.DeleteOrder(orders);
        }

        public async Task pdateOrders(Orders orders)
        {
            await _ordersRepository.UpdateOrder(orders);
        }

        public async Task<Orders> GetOrdersById(int orderId)
        {
            return await _ordersRepository.GetOrdersById(orderId);
        }

        public async Task<List<Orders>> ListOrdersAndMenuItems(int reservationId)
        {
            return await _ordersRepository.ListOrdersAndMenuItems(reservationId);
        }

        public async Task<List<MenuItems>> ListOrderedMenuItems(int reservationId)
        {
            return await _ordersRepository.ListOrderedMenuItems(reservationId);
        }
    }
}