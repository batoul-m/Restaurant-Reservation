using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Services.TabelsServices
{
    public class TabelsServices : ITablesServices
    {
        private readonly RestaurantReservationDbContext _context;
        async void CreateTable(Tabels table)
        {
            _context.Tabels.Add(table);
            await _context.SaveChangesAsync();
        }
        async void DeleteTable(Tabels table)
        {
            var exisitingTable = FindTable(table);
            if (exisitingTable is not null)
            {
                _context.Tabels.Remove(exisitingTable);
                await _context.SaveChangesAsync();
            }
        }
        async void UpdateTable(Tabels table)
        {
            var existingTabel = FindTable(table);
            if (existingTabel is not null)
            {
                existingTabel.TabelsId = table.TabelsId;
                existingTabel.ResturantId = table.ResturantId;
                existingTabel.Capacity = table.Capacity;
                await _context _context.SaveChangesAsync();
            }
        }
        bool FindTable(Tabels table)
        {
            return _context.Tabels.Find(table.TabelsId);
        }
    }
}