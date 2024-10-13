using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public class TableUpdate : ITableUpdate
    {
        void ITableUpdate.UpdateTable(RestaurantReservationDbContext context, Tabels tabel)
        {
            var existingTabel = context.Tabels.Find(tabel.TabelsId);
            if (existingTabel is not null)
            {
                existingTabel.TabelsId = tabel.TabelsId;
                existingTabel.ResturantId = tabel.ResturantId;
                existingTabel.Capacity = tabel.Capacity;
            }
        }
    }
}