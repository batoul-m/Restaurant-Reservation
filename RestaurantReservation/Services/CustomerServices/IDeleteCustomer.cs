using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface IDeleteCustomer
    {
        void DeleteCustomer(RestaurantReservationDbContext context,int customerId);
    }
}
