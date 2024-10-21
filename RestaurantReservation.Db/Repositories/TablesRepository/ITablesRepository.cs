using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.TablesRepository
{
    public interface ITablesRepository
    {
        void CreateTable(Tabels table);
        void DeleteTable(Tabels table);
        void UpdateTable(Tabels table);
        Task<bool> IsExisitTabels(int tabelsId)
    }
}