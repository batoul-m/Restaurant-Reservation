using RestaurantReservation.Services.ReservationsServices;
using RestaurantReservation.Db.Models;
namespace RestaurantReservation.Db.Repositories
{
    public class ReservationsRespositry : IReservationsRepository
    {
        private readonly ICreateReservations _createService;
        private readonly IDeleteReservations _deleteService;
        private readonly IUpdateReservations _updateService;
        public ReservationsRespositry(ICreateReservations createService,IDeleteReservations deleteService,IUpdateReservations updateService)
        {
            _createService = createService;
            _deleteService = deleteService;
            _updateService = updateService;
        }

        void IReservationsRepository.CreateReservations(Reservation reservation)
        {
            _createService.CreateReservation(reservation);
        }

        void IReservationsRepository.DeleteReservations(Reservation reservation)
        {
            _deleteService.DeleteReservation(reservation);
        }

        void IReservationsRepository.UpdateRseservations(Reservation reservation)
        {
            _updateService.UpdateReservation(reservation);
        }
    }
}
