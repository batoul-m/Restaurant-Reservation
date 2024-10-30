using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Models.Views;
using RestaurantReservation.Db.Repositories.ViewsRepositories.ReservationWithDetailsRepositroy;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.ViewsServices.ReservationWithDetails 
{
    public class ReservationWithDetails : IReservationWithDetails
    {
        private readonly IReservationWithDetailsRepository _reservationWithDetailsRepository;
        
        public ReservationWithDetails(IReservationWithDetailsRepository reservationWithDetailsRepository)
        {
            _reservationWithDetailsRepository = reservationWithDetailsRepository;
        }

        public async Task<ArrayList> GetReservationsWithDetailsAsync()
        {
            return await _reservationWithDetailsRepository.GetReservationsWithDetailsAsync();
        }
    }
}