using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Repositories.TablesRepository
{
    public class TabelsRespositry : ITablesRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public TabelsRespositry(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public Task CreateTable(Tabels table)
        {
            _context.Tabels.Add(table);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTable(Tabels table)
        {
            var exisitingTable = GetTabelsById(table.TabelsId);
            if (exisitingTable is not null)
            {
                _context.Tabels.Remove(exisitingTable);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTable(Tabels table)
        {
            var existingTabel = GetTabelsById(table.TabelsId);
            if (existingTabel is not null)
            {
                existingTabel.ResturantId = table.ResturantId;
                existingTabel.Capacity = table.Capacity;
                await _context _context.SaveChangesAsync();
            }
        }
        
        public async Task<Tabels> GetTabelsById(int tabelsId)
        {
            return await _context.Tabels.FindAsync(tabelsId);
        }
    }
}