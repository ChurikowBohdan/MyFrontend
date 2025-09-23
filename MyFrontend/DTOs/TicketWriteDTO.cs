namespace MyFrontend.DTOs
{
    public class TicketWriteDTO
    {
        public int TrainRouteId { get; set; }
        public int PriceId { get; set; }
        public int CustomerId { get; set; }
        public int DepartureStationId { get; set; }
        public int DestinationStationId { get; set; }
        public double CarriageWeight { get; set; }
        public int Seat { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
