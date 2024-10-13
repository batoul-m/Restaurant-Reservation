using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public class TableDelete : ITableDelete
    {
        void ITableDelete.DeleteTable(RestaurantReservationDbContext context, int tabelId)
        {
            var exisitingTable = context.Tabels.Find(tabelId);
            if (exisitingTable is not null)
            {
                context.Tabels.Remove(exisitingTable);
                context.SaveChanges();
            }
        }
    }
}