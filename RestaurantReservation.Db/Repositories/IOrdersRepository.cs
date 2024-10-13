using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public interface IOrdersRepository
    {
        void CreateOrders(Orders orders);
        void DeleteOrders(Orders orders);
        void UpdateOrders(Orders orders);
    }
}