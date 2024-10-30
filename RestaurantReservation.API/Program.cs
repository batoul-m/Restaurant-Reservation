using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using RestaurantReservation.Db; 
using RestaurantReservation.API.Middlewares; 
using Swashbuckle.AspNetCore.SwaggerGen;
using RestaurantReservation.API.Helpers;
using RestaurantReservation.API.Services; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DbContextData>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

// Register services
builder.Services.AddScoped<ICustomerServices, CustomerServices>();
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();
builder.Services.AddScoped<IMenuItemsServices, MenuItemsServices>();
builder.Services.AddScoped<IOrderItemsServices, OrderItemsServices>();
builder.Services.AddScoped<IOrdersServices, OrdersServices>();
builder.Services.AddScoped<IReservationsServices, ReservationsServices>();
builder.Services.AddScoped<IRestaurantServices, RestaurantServices>();
builder.Services.AddScoped<ITablesServices, TablesServices>();
builder.Services.AddScoped<IUsers, UserServices>();
builder.Services.AddScoped<IJWTTokenServices, JWTTokenServices>();

// Register repositories
builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IMenuItemsRepository, MenuItemsRepository>();
builder.Services.AddScoped<IOrderItemsRepository, OrderItemsRepository>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddScoped<IReservationsRepository, ReservationsRepository>();
builder.Services.AddScoped<IRestaurantsRepository, RestaurantsRepository>();
builder.Services.AddScoped<ITablesRepository, TablesRepository>();
// Register Views Repositories 
builder.Services.AddScoped<IEmployeesWithRestaurantDetailsRepository, EmployeesWithRestaurantDetailsRepository>();
builder.Services.AddScoped<IReservationWithDetailsRepository, ReservationWithDetailsRepository>();


// Add services to the container.
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    var key = Encoding.UTF8.GetBytes(builder.Configuration["JWTToken:Key"]);
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JWTToken:Issuer"],
        ValidAudience = builder.Configuration["JWTToken:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Restaurant Reservation API", Version = "v1" });
});

var app = builder.Build();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Restaurant Reservation API V1");
    c.RoutePrefix = string.Empty; 
});

app.UseHttpsRedirection();
app.UseMiddleware<ErrorHandlingMiddleware>(); 
app.UseAuthentication();
app.UseAuthorization();

app.Run();