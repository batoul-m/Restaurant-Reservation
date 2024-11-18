namespace RestaurantReservation.Db.Models;
public class Restaurants
{
    public int ReservationId { get; set; }
    public string Name { get; set;}
    public string Address { get; set; }
    public string OpeningHour { get; set; }
    public int PhoneNumber { get; set; }
    public ICollection<Employees> Employees { get; set; }
    public ICollection<Tabels> Tables { get; set; }
    public ICollection<MenuItems> MenuItems { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}