namespace MyFrontend.DTOs
{
    public class TrainRouteReadDTO
    {
        public int TrainRouteId { get; set; }
        public int TrainId { get; set; }
        public string Name { get; set; }
        public ICollection<int> RoutePointsIds { get; set; }
    }
}
