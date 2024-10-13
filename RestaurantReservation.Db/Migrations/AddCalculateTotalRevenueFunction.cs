using Microsoft.EntityFrameworkCore.Migrations;
public partial class AddCalculateTotalRevenueFunction : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql(@"
            CREATE FUNCTION CalculateTotalRevenue(@RestaurantId INT)
            RETURN DECIMAL(18,2)
            AS
            BRGIN
                DECLARE @TotalRevenue DECIMAL(18,2)
                SELECT @TotalRevenue = SUM(o.TotalAmount)
                FROM Orders o
                JOIN Reservation r ON r.ReservationId = o.ReservationId
                WHERE r.RestaurantId = @RestaurantId
                Retuen @TotalRevenue 
            END
        ");
    }
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DROPE FUNCTION CalculateTotalRevenue");
    }
}