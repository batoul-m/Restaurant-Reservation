using RestaurantReservation.Db.Repositories.OrdersRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrdersServices
{
    public class OrderService : IOrderServices 
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrdersRespositry(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        async void CreateOrders(Orders orders)
        {
            await _ordersRepository.CreateOrder(orders);
        }

        async void DeleteOrders(Orders orders)
        {
            await _ordersRepository.DeleteOrder(orders);
        }

        async void pdateOrders(Orders orders)
        {
            await _ordersRepository.UpdateOrder(orders);
        }
        async Task<List<Orders>> ListOrdersAndMenuItems(int reservationId)
        {
            return await _ordersRepository.ListOrdersAndMenuItems(reservationId);
        }

        async Task<List<MenuItems>> ListOrderedMenuItems(int reservationId)
        {
            return await _ordersRepository.ListOrderedMenuItems(reservationId);
        }
    }
}