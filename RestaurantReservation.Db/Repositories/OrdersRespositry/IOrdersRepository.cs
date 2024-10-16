using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.OrdersRepository
{
    public interface IOrdersRepository
    {
        void CreateOrders(Orders orders);
        void DeleteOrders(Orders orders);
        void UpdateOrders(Orders orders);
        Task<List<Orders>> IOrderServices.ListOrdersAndMenuItems(int reservationId);
        Task<List<MenuItems>> IOrderServices.ListOrderedMenuItems(int reservationId);
    }
}