using RestaurantReservation.Db.Repositories.ReservationsRepository;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Services.ReservationsServices
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationsRepository _reservationsRepository;
        public ReservationsRespositry(IReservationsRepository reservationsRepository)
        {
            _reservationsRepository = reservationsRepository;
        }

        async void CreateReservations(Reservation reservation)
        {
            await _reservationsRepository.CreateReservation(reservation);
        }

        async void DeleteReservations(Reservation reservation)
        {
            await _reservationsRepository.DeleteReservation(reservation);
        }

        async void UpdateRseservations(Reservation reservation)
        {
            await _reservationsRepository.UpdateReservation(reservation);
        }
        async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
        {
            return await _reservationsRepository.GetReservationByCustomer(customerId);
        }
    }
}
