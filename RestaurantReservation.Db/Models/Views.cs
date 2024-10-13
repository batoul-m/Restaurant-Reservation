namespace RestaurantReservation.Db.Models;
public class ReservationWithDetails
{
    public int ReservationId { get; set; }
    public string CustomerFirstName { get; set; }
    public string CustomerLastName { get; set; }
    public string RestaurantName { get; set; }
    public DateTime ReservationDate { get; set; }
}

public class EmployeeWithRestaurantDetails
{
    public int EmployeeId { get; set; }
    public string EmployeeFirstName { get; set; }
    public string EmployeeLastName { get; set; }
    public string Position { get; set; }
    public string RestaurantName { get; set; }
}
