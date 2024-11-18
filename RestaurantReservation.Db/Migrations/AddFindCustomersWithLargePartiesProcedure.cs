using Microsoft.EntityFrameworkCore.Migrations;
public class AddFindCustomersWithLargePartiesProcedure : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql(@"
            CREATE PROCEDURE FindCustomersWithLargeParties
                @PartySize INT
            AS
            BEGIN
                SELECT c.FirstName , c.LastName , c.Email
                FROM Customers c
                JOIN Reservations r ON r.ReservationId = c.ReservationId 
                WHERE r.PartySize > @PartySize
            END
        ");
    }
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql(@"DROPE PROCEDURE FindCustomersWithLargeParties");
    }
}