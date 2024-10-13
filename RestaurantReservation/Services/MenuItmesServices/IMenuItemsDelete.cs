using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsDelete
    {
        void DeleteItems(RestaurantReservationDbContext context,int ItemId);
    }
}
