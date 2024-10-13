using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITableDelete
    {
        void DeleteTable(RestaurantReservationDbContext context,int tabelId);
    }
}