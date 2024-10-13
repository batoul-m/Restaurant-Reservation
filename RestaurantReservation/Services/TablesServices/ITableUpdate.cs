using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITableUpdate
    {
        void UpdateTable(RestaurantReservationDbContext context,Tabels tabel);
    }
}