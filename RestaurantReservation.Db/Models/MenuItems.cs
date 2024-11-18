namespace RestaurantReservation.Db.Models;
public class MenuItems
{
    public int ItemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int ResturantId { get; set;}
    public Restaurants Restaurants{ get; set; }
    public ICollection<OrderItems> OrderItems{ get; set; }
}