using RestaurantReservation.Db.Repositories.TablesRepository;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.TabelsServices
{
    public class TabelsServices : ITablesServices
    {
        private readonly ITablesRepository _tablesRepository;

        public TabelsServices(ITablesRepository tablesRepository)
        {
            _tablesRepository = tablesRepository;
        }

        public async Task CreateTables(Tabels tabels)
        {
            await _tablesRepository.CreateTables(tabels);
        }

        public async Task DeleteTables(Tabels tabels)
        {
           await _tablesRepository.DeleteTables(tabels);
        }

        public async Task UpdateTables(Tabels tabels)
        {
            await _tablesRepository.UpdateTables(tabels);
        }

        public async Task<Tabels> GetTablesById(int id)
        {
            return await _tablesRepository.GetTablesById(id);
        }
    }
}