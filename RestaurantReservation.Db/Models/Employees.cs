namespace RestaurantReservation.Db.Models;
public class Employees 
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public int ResturantId { get; set; }
    public Restaurants Restaurants { get; set; }
    public ICollection<Orders> orders{ get; set; }
    
}