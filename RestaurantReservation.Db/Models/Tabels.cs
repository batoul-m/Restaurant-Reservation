namespace RestaurantReservation.Db.Models;
public class Tabels
{
    public int TabelsId { get; set; }
    public double Capacity { get; set; }
    public int ResturantId { get; set;}
    public virtual Restaurants Restaurants{ get; set; }
    public ICollection<Reservation> Reservations{ get; set; }
}