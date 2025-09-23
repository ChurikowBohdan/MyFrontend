namespace MyFrontend.DTOs
{
    public class TicketReadDTO
    {
        public int TicketId { get; set; }
        public int TrainRouteId { get; set; }
        public int PriceId { get; set; }
        public int CustomerId { get; set; }
        public int DepartureStationId { get; set; }
        public int DestinationStationId { get; set; }
        public double CarriageWeight { get; set; }
        public int Seat { get; set; }
        public decimal CarriagePrice { get; set; }
        public decimal RoadPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
