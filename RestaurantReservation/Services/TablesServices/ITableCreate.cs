using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITableCreate
    {
        void CreateTable(RestaurantReservationDbContext context,Tabels tabel);
    }
}