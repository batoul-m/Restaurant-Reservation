using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface ICreateCustomer
    {
        void CreateCustomer(RestaurantReservationDbContext context,Customers customer);
    }
}
