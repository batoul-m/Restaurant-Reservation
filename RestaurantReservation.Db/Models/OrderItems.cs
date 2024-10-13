namespace RestaurantReservation.Db.Models;
public class OrderItems
{
    public int OrderItemsId { get; set; }
    public double Quantity { get; set; }
    public int OrdersId { get; set; } 
    public Orders Orders{ get; set; }    
    public int ItemId { get; set; } 
    public MenuItems MenuItems { get; set; } 
}