namespace MyFrontend.DTOs
{
    public class RoutePointReadDTO
    {
        public int RoutePointId { get; set; }
        public int TrainRouteId { get; set; }
        public int StationId { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        public int Platform { get; set; }
        public int Order { get; set; }
        public double DistanceFromPreviousStation { get; set; }
    }
}
