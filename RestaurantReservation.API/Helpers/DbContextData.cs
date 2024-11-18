using Microsoft.EntityFrameworkCore;
using RestaurantReservation.API.Entities;

namespace RestaurantReservation.API.Helpers
{
    public class DbContextData : DbContext 
    {
        public DbContextData(DbContextOptions<DbContextData> options) : base(options) { }

        public virtual DbSet<Users> Users { get; set; }
    }
}
