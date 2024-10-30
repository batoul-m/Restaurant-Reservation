namespace RestaurantReservation.Db.Models.Views{
    public class ReservationWithDetails
    {
        public int ReservationId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string RestaurantName { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}