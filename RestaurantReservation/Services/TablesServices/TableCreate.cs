using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public class TableCreate : ITableCreate
    {
        void ITableCreate.CreateTable(RestaurantReservationDbContext context, Tabels tabel)
        {
            context.Tabels.Add(tabel);
            context.SaveChanges();
        }
    }
}