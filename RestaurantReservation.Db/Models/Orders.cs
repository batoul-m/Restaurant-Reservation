namespace RestaurantReservation.Db.Models;
public class Orders
{
    public int OrderId { get; set; }
    public int ReservationId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public Reservation Reservation { get; set; }
    public Employees Employee { get; set; }
    public ICollection<OrderItems> OrderItems { get; set; }
}