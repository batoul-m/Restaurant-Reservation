using RestaurantReservation.API.Entities;

namespace RestaurantReservation.API.Services
{
    public interface IUsers
    {
        IEnumerable<Users> GetAll();
    }
}
