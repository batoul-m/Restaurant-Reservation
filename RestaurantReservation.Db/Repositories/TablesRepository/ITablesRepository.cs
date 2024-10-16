using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.TablesRepository
{
    public interface ITablesRepository
    {
        void CreateTables(Tabels tabels);
        void DeleteTables(Tabels tabels);
        void UpdateTables(Tabels tabels);
    }
}