using System.Collections;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ViewsServices
{
    public interface IReservationWithDetails
    {
        Task<ArrayList> GetReservationsWithDetailsAsync();   
    }
}