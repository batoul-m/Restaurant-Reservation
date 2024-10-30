using System.Collections;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
using system.Threading.Tasks;

namespace RestaurantReservation.Services.ViewsServices.ReservationWithDetails 
{
    public interface IReservationWithDetails
    {
        public Task<ArrayList> GetReservationsWithDetailsAsync();   
    }
}