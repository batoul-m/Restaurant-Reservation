using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext : DbContext{
        private readonly IConfiguration _configuration;
        public RestaurantReservationDbContext(DbContextOptions<RestaurantReservationDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Orders> Orders{ get; set; }
        public DbSet<OrderItems> OrderItems{ get; set; }
        public DbSet<MenuItems> MenuItems{ get; set; }
        public DbSet<Employees> Employees{ get; set; }
        public DbSet<Tabels> Tabels{ get; set; }
        public DbSet<Restaurants> Restaurants{ get; set; }
        public DbSet<ReservationWithDetails> ReservationWithDetails { get; set; }
        public DbSet<EmployeeWithRestaurantDetails> EmployeeWithRestaurantDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);
                entity.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(c => c.LastName).IsRequired().HasMaxLength(50);
                entity.Property(c => c.Email).IsRequired();
                entity.Property(c => c.PhoneNumber).IsRequired();
            });
             // Reservation
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(r => r.ReservationId);
                entity.Property(r => r.ReservationDate).IsRequired();
                entity.Property(r => r.PartySize).IsRequired();

                // Relationships
                entity.HasOne(r => r.Customer)
                      .WithMany(c => c.Reservations)
                      .HasForeignKey(r => r.CustomerId);

                entity.HasOne(r => r.Restaurant)
                      .WithMany(res => res.Reservations)
                      .HasForeignKey(r => r.RestaurantId);

                entity.HasOne(r => r.Table)
                      .WithMany(t => t.Reservations)
                      .HasForeignKey(r => r.TableId);
            });

            // Order
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(o => o.OrderId);
                entity.Property(o => o.OrderDate).IsRequired();
                entity.Property(o => o.TotalAmount).HasColumnType("decimal(18,2)");

                // Relationships
                entity.HasOne(o => o.Reservation)
                      .WithMany(r => r.Orders)
                      .HasForeignKey(o => o.ReservationId);

                entity.HasOne(o => o.Employee)
                      .WithMany(e => e.orders)
                      .HasForeignKey(o => o.EmployeeId);
            });

            // OrderItem
            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.HasKey(oi => oi.OrderItemsId);
                entity.Property(oi => oi.Quantity).IsRequired();

                // Relationships
                entity.HasOne(oi => oi.Orders)
                      .WithMany(o => o.OrderItems)
                      .HasForeignKey(oi => oi.OrdersId);

                entity.HasOne(oi => oi.MenuItems)
                      .WithMany(mi => mi.OrderItems)
                      .HasForeignKey(oi => oi.ItemId);
            });

            // MenuItem
            modelBuilder.Entity<MenuItems>(entity =>
            {
                entity.HasKey(mi => mi.ItemId);
                entity.Property(mi => mi.Name).IsRequired().HasMaxLength(100);
                entity.Property(mi => mi.Price).HasColumnType("decimal(18,2)");

                // Relationships
                entity.HasOne(mi => mi.Restaurants)
                      .WithMany(r => r.MenuItems)
                      .HasForeignKey(mi => mi.ResturantId);
            });

            // Employee
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeID);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Position).IsRequired();

                // Relationships
                entity.HasOne(e => e.Restaurants)
                      .WithMany(r => r.Employees)
                      .HasForeignKey(e => e.ResturantId);
            });

            // Table
            modelBuilder.Entity<Tabels>(entity =>
            {
                entity.HasKey(t => t.TabelsId);
                entity.Property(t => t.Capacity).IsRequired();

                // Relationships
                entity.HasOne(t => t.Restaurants)
                      .WithMany(r => r.Tables)
                      .HasForeignKey(t => t.ResturantId);
            });

            // Restaurant
            modelBuilder.Entity<Restaurants>(entity =>
            {
                entity.HasKey(r => r.ReservationId);
                entity.Property(r => r.Name).IsRequired().HasMaxLength(100);
                entity.Property(r => r.Address).IsRequired().HasMaxLength(255);
                entity.Property(r => r.PhoneNumber).IsRequired();
                entity.Property(r => r.OpeningHour).IsRequired();
            });
            //for Views 
            modelBuilder.Entity<ReservationWithDetails>().HasNoKey().ToView("vw_ReservationsWithDetails");
            modelBuilder.Entity<EmployeeWithRestaurantDetails>().HasNoKey().ToView("vw_EmployeesWithRestaurantDetails");
            base.OnModelCreating(modelBuilder);        
        } 
        //Seeds the tables with at least 5 record for each
        public async void SeedAsync()
        {
            if (!Customers.Any())
            {
                Customers.AddRange(
                new Customers { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = 1234567890 },
                new Customers { FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com", PhoneNumber = 0987654321 },
                new Customers { FirstName = "Alice", LastName = "Smith", Email = "alice.smith@example.com", PhoneNumber = 1112223333 },
                new Customers { FirstName = "Bob", LastName = "Brown", Email = "bob.brown@example.com", PhoneNumber = 444555666 },
                new Customers { FirstName = "Charlie", LastName = "Johnson", Email = "charlie.johnson@example.com", PhoneNumber = 778889999 }
            );
                await SaveChangesAsync();
            }
            if (!Employees.Any())
            {
                Employees.AddRange(
                new Employees { FirstName = "Emma", LastName = "Wilson", Position = "Manager", ResturantId  = 1 },
                new Employees { FirstName = "Liam", LastName = "Johnson", Position = "Chef", ResturantId  = 2 },
                new Employees { FirstName = "Olivia", LastName = "Brown", Position = "Waiter", ResturantId  = 3 },
                new Employees { FirstName = "Noah", LastName = "Davis", Position = "Waiter", ResturantId  = 4 },
                new Employees { FirstName = "Sophia", LastName = "Miller", Position = "Host", ResturantId  = 5 }
            );
                await SaveChangesAsync();
            }             
            if (!MenuItems.Any())
            {
                MenuItems.AddRange(
                new MenuItems { Name = "Cheeseburger", Description = "Juicy beef burger with cheese", Price = 9.99, ResturantId  = 2 },
                new MenuItems { Name = "Pasta Carbonara", Description = "Classic Italian pasta with creamy sauce", Price = 12.99, ResturantId = 3 },
                new MenuItems { Name = "Tacos", Description = "Tasty beef and chicken tacos", Price = 8.99, ResturantId  = 4 },
                new MenuItems { Name = "Sushi Roll", Description = "Fresh salmon sushi roll", Price = 14.99, ResturantId  = 5 },
                new MenuItems { Name = "Grilled Steak", Description = "Tender grilled steak", Price = 19.99, ResturantId  = 1 }
            );
                await SaveChangesAsync();
            }
            if (!Restaurants.Any())
            {
                Restaurants.AddRange(
                    new Restaurants { Name = "The Gourmet Place", Address = "123 Fine Dining St.", PhoneNumber = 551234567, OpeningHour = "9 AM - 10 PM" },
                    new Restaurants { Name = "Burger Shack", Address = "456 Fast Food Ave.", PhoneNumber = 552345678, OpeningHour = "11 AM - 11 PM" },
                    new Restaurants { Name = "Pasta Palace", Address = "789 Italian Way", PhoneNumber = 555345678, OpeningHour = "12 PM - 9 PM" },
                    new Restaurants { Name = "Taco Town", Address = "321 Mexican Blvd.", PhoneNumber = 555456789, OpeningHour = "10 AM - 8 PM" },
                    new Restaurants { Name = "Sushi Central", Address = "654 Sushi Dr.", PhoneNumber = 555678901, OpeningHour = "10 AM - 10 PM" }
            );
                await SaveChangesAsync();
            }
        }
        //implement calculate revenue function
        public async Task<decimal> CalculateTotalRevenue(int restaurantId)
        {
            var totalRevenue = await this.Database.ExecuteSqlRawAsync("SELECT dbo.CalculateTotalRevenue({0})", restaurantId);
            return totalRevenue;
            
        }
        public async Task<List<Customers>> FindCustomersWithLargeParties(int partySize)
        {
            return await this.Customers.FromSqlRaw("EXEC FindCustomersWithLargeParties @PartySize = {0}",partySize).ToListAsync();
        }
    }
}