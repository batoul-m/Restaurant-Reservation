using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.ReservationsServices;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        // POST: api/reservation
        [HttpPost]
        public async Task<IActionResult> CreateReservation([FromBody] Reservation reservation)
        {
            if (reservation is null)
            {
                return BadRequest("Reservation cannot be null.");
            }

            var createdReservation = await _reservationService.CreateReservation(reservation);
            return CreatedAtAction(nameof(GetReservationById), new { id = createdReservation.ReservationId }, createdReservation);
        }

        // GET: api/reservation/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservationById(int id)
        {
            var reservation = await _reservationService.GetReservationById(id);
            if (reservation is null)
            {
                return NotFound("Reservation not found.");
            }
            return Ok(reservation);
        }

        // PUT: api/reservation
        [HttpPut]
        public async Task<IActionResult> UpdateReservation([FromBody] Reservation reservation)
        {
            if (reservation is null)
            {
                return BadRequest("Reservation cannot be null.");
            }

            var updated = await _reservationService.UpdateReservation(reservation);
            if (!updated)
            {
                return NotFound("Reservation not found.");
            }
            return NoContent();
        }

        // DELETE: api/reservation/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _reservationService.GetReservationById(id);
            if (reservation is null)
            {
                return NotFound("Reservation not found.");
            }

            await _reservationService.DeleteReservation(reservation);
            return NoContent();
        }

        // GET: api/reservations/customer/{customerId}
        [HttpGet("customer/{customerId}")]
        public async Task<IActionResult> GetReservationsByCustomerId(int customerId)
        {
            var reservations = await _reservationService.GetReservationsByCustomerId(customerId);
            if (reservations is null || !reservations.Any())
            {
                return NotFound("No reservations found for this customer.");
            }
            return Ok(reservations);
        }
    }
}
