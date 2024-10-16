using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITablesServices
    {
        void CreateTable(Tabels table);
        void DeleteTable(Tabels table);
        void UpdateTable(Tabels table);
        bool FindTable(Tabels table);
    }
}