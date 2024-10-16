using RestaurantReservation.Services.ReservationsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories.ReservationsRepository
{
    public class ReservationsRespositry : IReservationsRepository
    {
        private readonly IReservationService _reservationService;
        public ReservationsRespositry(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        void IReservationsRepository.CreateReservations(Reservation reservation)
        {
            _reservationService.CreateReservation(reservation);
        }

        void IReservationsRepository.DeleteReservations(Reservation reservation)
        {
            _reservationService.DeleteReservation(reservation);
        }

        void IReservationsRepository.UpdateRseservations(Reservation reservation)
        {
            _reservationService.UpdateReservation(reservation);
        }
        Task<List<Reservation>> IReservationService.GetReservationsByCustomer(int customerId)
        {
            return _reservationService.GetReservationByCustomer(customerId);
        }
    }
}
