## Restaurant Reservation API (.NET 8)

Restaurant reservation backend built with **ASP.NET Core Web API (.NET 8)**, **Entity Framework Core**, **SQL Server**, and **JWT authentication**.

### Repository structure

- **`RestaurantReservation.API/`**: Web API project (controllers, JWT auth, Swagger)
- **`RestaurantReservation.Db/`**: EF Core models + repositories/data access
- **`RestaurantReservation/`**: additional project containing services (domain/business logic)
- **`WebApplication1.sln`**: solution file

### Prerequisites

- **.NET SDK 8** (`dotnet --version`)
- **SQL Server** (LocalDB/SQL Server Express/full instance)

### Configuration

The API reads configuration from:

- `RestaurantReservation.API/appsettings.json`
- `RestaurantReservation.API/appsettings.Development.json` (overrides when `ASPNETCORE_ENVIRONMENT=Development`)

Update the connection string in `RestaurantReservation.API/appsettings.json`:

- `ConnectionStrings:DefaultConnection`: SQL Server connection string for your environment

JWT settings are configured in the same file:

- `JWTToken:Key`
- `JWTToken:Issuer`
- `JWTToken:Audience`

### Run the API

From the repo root:

```bash
dotnet restore
dotnet run --project RestaurantReservation.API
```

By default (see `RestaurantReservation.API/Properties/launchSettings.json`) the API runs on:

- `http://localhost:5024`
- `https://localhost:7167`

Swagger UI is configured at the root URL, so open:

- `http://localhost:5024/` (or `https://localhost:7167/`)

### Authentication (JWT)

Most endpoints require authentication (`[Authorize]`). To get a token:

- **POST** `api/Users/Authenticate`
- Body example:

```json
{
  "userName": "your-username",
  "password": "your-password",
  "firstName": "OptionalForAuth",
  "lastName": "OptionalForAuth"
}
```

Use the returned token as:

- `Authorization: Bearer <token>`

### API endpoints (high-level)

Controllers live in `RestaurantReservation.API/Controllers/` and include:

- `api/Customer`
- `api/Employees`
- `api/MenuItems`
- `api/OrderItems`
- `api/Orders`
- `api/Reservations`
- `api/Restaurants`
- `api/Tables`
- `api/Users`

See Swagger for the full list of routes and request/response schemas.

### Known issues / things to fix if the app won’t start

- **Controllers not registered**: `RestaurantReservation.API/Program.cs` calls `app.MapControllers()` but does **not** call `builder.Services.AddControllers()`. If you get 404s for controller routes, add:
  - `builder.Services.AddControllers();`
- **Connection string key mismatch**: `RestaurantReservation.API/Program.cs` uses:
  - `builder.Configuration.GetConnectionString("connection")`
  but `appsettings.json` defines:
  - `ConnectionStrings:DefaultConnection`
  Fix by either updating `Program.cs` to `"DefaultConnection"` or adding a `"connection"` entry in `ConnectionStrings`.

### Notes

- This repo does not include database migrations in the root; if you want EF migrations, you can add them via `dotnet ef migrations add ...` (requires EF tools) and point to the correct startup project.

