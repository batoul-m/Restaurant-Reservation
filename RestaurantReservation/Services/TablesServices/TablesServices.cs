using RestaurantReservation.Db.Repositories.TablesRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.TabelsServices
{
    public class TabelsServices : ITablesServices
    {
        private readonly ITablesRepository _tablesRepository;
        public TabelsRespositry(ITablesRepository tablesRepository)
        {
            _tablesRepository = tablesRepository;
        }

        async void CreateTables(Tabels tabels)
        {
            await _tablesRepository.CreateTables(tabels);
        }

        async void DeleteTables(Tabels tabels)
        {
           await _tablesRepository.DeleteTables(tabels);
        }

        async void UpdateTables(Tabels tabels)
        {
            await _tablesRepository.UpdateTables(tabels);
        }
    }
}