using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServices
    {
        void CreateOrders(Orders orders);
        void DeleteOrders(Orders orders);
        void UpdateOrders(Orders orders);
        Task<List<Orders>> ListOrdersAndMenuItems(int reservationId);
        Task<List<MenuItems>> ListOrderedMenuItems(int reservationId);
    }
}