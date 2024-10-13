namespace RestaurantReservation.Db.Models;
public class Customers
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public ICollection<Reservation> Reservations { get; set; }

}
