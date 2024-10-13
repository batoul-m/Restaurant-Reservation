using RestaurantReservation.Services.TabelsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class TabelsRespositry : ITablesRepository
    {
        private readonly ICreateTabels _createService;
        private readonly IDeleteTabels _deleteService;
        private readonly IUpdateTabels _updateService;
        public TabelsRespositry(ICreateTabels createService,IDeleteTabels deleteService,IUpdateTabels updateService)
        {
            _createService = createService;
            _deleteService = deleteService;
            _updateService = updateService;
        }

        void ITablesRepository.CreateTables(Tabels tabels)
        {
            _createService.CreateTables(tabels);
        }

        void ITablesRepository.DeleteTables(Tabels tabels)
        {
            _deleteService.DeleteTables(tabels);
        }

        void ITablesRepository.UpdateTables(Tabels tabels)
        {
            _updateService.UpdateTables(tabels);
        }
    }
}