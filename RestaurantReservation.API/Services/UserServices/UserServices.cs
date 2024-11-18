using RestaurantReservation.API.Entities;
using RestaurantReservation.API.Helpers;

namespace RestaurantReservation.API.Services
{
    public class UserServices : IUsers
    {
        private readonly DbContextData _dbContext;

        public UserServices(DbContextData dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Users> GetAll()
        {
            return _dbContext.Users.ToList();
        }
    }
}
