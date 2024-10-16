using System.Collections;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ViewsServices.ReservationWithDetails 
{
    public interface IReservationWithDetails
    {
        Task<ArrayList> GetReservationsWithDetailsAsync();   
    }
}