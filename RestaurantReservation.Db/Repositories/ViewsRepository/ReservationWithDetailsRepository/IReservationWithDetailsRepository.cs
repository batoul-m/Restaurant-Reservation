using System.Threading.Tasks;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;

namespace RestaurantReservation.Db.Repositories.ViewsRepositories.ReservationWithDetailsReposiroty
{
    public interface IReservationWithDetailsReposiroty
    {
        public Task<ArrayList> GetReservationsWithDetailsAsync();
    }
}