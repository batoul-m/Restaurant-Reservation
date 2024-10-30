using RestaurantReservation.Db.Repositories.ReservationsRepository;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Services.ReservationsServices
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationsRepository _reservationsRepository;

        public ReservationService(IReservationsRepository reservationsRepository)
        {
            _reservationsRepository = reservationsRepository;
        }

        public async Task CreateReservations(Reservation reservation)
        {
            await _reservationsRepository.CreateReservation(reservation);
        }

        public async Task DeleteReservations(Reservation reservation)
        {
            await _reservationsRepository.DeleteReservation(reservation);
        }

        public async Task UpdateRseservations(Reservation reservation)
        {
            await _reservationsRepository.UpdateReservation(reservation);
        }

        public async Task<Reservation> GetReservationsById(int reservationId)
        {
            return await _reservationsRepository.GetReservationById(reservationId);
        }
        
        public async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
        {
            return await _reservationsRepository.GetReservationByCustomer(customerId);
        }
    }
}
