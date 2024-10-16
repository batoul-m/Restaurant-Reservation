using RestaurantReservation.Services.TablesServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.TablesRepository
{
    public class TabelsRespositry : ITablesRepository
    {
        private readonly ITablesServices _tablesServices
        public TabelsRespositry(ITablesServices tablesServices)
        {
            _tablesServices = tablesServices;
        }

        void ITablesRepository.CreateTables(Tabels tabels)
        {
            _tablesServices.CreateTables(tabels);
        }

        void ITablesRepository.DeleteTables(Tabels tabels)
        {
            _tablesServices.DeleteTables(tabels);
        }

        void ITablesRepository.UpdateTables(Tabels tabels)
        {
            _tablesServices.UpdateTables(tabels);
        }
    }
}