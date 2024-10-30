using RestaurantReservation;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITablesServices
    {
        public Task CreateTables(Tabels tabels);
        public Task DeleteTables(Tabels tabels);
        public Task UpdateTables(Tabels tabels);
        public Task<Tabels> GetTablesById(int id);
    }
}