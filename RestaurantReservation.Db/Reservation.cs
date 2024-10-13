namespace RestaurantReservation.Db;
public class Reservation
{
    public int ReservationId { get; set; }
    public int CustomerId { get; set; }
    public int RestaurantId { get; set; }
    public int TableId { get; set; }
    public DateTime ReservationDate { get; set; }
    public int PartySize { get; set; }
    public Customers Customer { get; set; }
    public Restaurants Restaurant { get; set; }
    public Tabels Table { get; set; }
    public ICollection<Orders> Orders { get; set; }
}
