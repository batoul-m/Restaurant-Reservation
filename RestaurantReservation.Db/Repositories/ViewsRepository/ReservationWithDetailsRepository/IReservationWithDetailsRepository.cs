using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
namespace RestaurantReservation.Db.Repositories.ViewsRepositories.ReservationWithDetailsReposiroty
{
    public interface IReservationWithDetailsReposiroty
    {
        Task<ArrayList> GetReservationsWithDetailsAsync();
    }
}