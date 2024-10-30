using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.TablesRepository
{
    public interface ITablesRepository
    {
        public Task CreateTable(Tabels table);
        public Task DeleteTable(Tabels table);
        public Task UpdateTable(Tabels table);
        public Task<Tabels> GetTabelsById(int tabelsId)
    }
}