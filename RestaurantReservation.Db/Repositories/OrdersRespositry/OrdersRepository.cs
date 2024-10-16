using RestaurantReservation.Services.OrdersServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.OrdersRepository
{
    public class OrdersRespositry : IOrdersRepository
    {
        private readonly IOrderServices _orderServices;
        public OrdersRespositry(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        void IOrdersRepository.CreateOrders(Orders orders)
        {
            _orderServices.CreateOrder(orders);
        }

        void IOrdersRepository.DeleteOrders(Orders orders)
        {
            _orderServices.DeleteOrder(orders);
        }

        void IOrdersRepository.UpdateOrders(Orders orders)
        {
            _orderServices.UpdateOrder(orders);
        }
        Task<List<Orders>> IOrderServices.ListOrdersAndMenuItems(int reservationId)
        {
            return _orderServices.ListOrdersAndMenuItems(reservationId);
        }

        Task<List<MenuItems>> IOrderServices.ListOrderedMenuItems(int reservationId)
        {
            return _orderServices.ListOrderedMenuItems(reservationId);
        }
    }
}