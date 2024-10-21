using RestaurantReservation;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITablesServices
    {
        void CreateTables(Tabels tabels);
        void DeleteTables(Tabels tabels);
        void UpdateTables(Tabels tabels);
    }
}