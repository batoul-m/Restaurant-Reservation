using RestaurantReservation.API.Entities;

namespace RestaurantReservation.API.Services
{
    public interface IJWTTokenServices
    {
        JWTTokens Authenticate(Users users);
    }
}
