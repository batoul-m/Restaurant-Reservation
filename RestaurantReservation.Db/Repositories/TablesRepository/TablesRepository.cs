using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.TablesRepository
{
    public class TabelsRespositry : ITablesRepository
    {
        private readonly RestaurantReservationDbContext _context;
        async void CreateTable(Tabels table)
        {
            _context.Tabels.Add(table);
            await _context.SaveChangesAsync();
        }
        async void DeleteTable(Tabels table)
        {
            var exisitingTable = IsExisitTabels(table.TabelsId);
            if (exisitingTable is not null)
            {
                _context.Tabels.Remove(exisitingTable);
                await _context.SaveChangesAsync();
            }
        }
        async void UpdateTable(Tabels table)
        {
            var existingTabel = IsExisitTabels(table.TabelsId);
            if (existingTabel is not null)
            {
                existingTabel.ResturantId = table.ResturantId;
                existingTabel.Capacity = table.Capacity;
                await _context _context.SaveChangesAsync();
            }
        }
        
        public async Task<Tabels> IsExisitTabels(int tabelsId)
        {
            return await _context.Tabels.FindAsync(c => c.TabelsId == tabelsId);
        }
    }
}