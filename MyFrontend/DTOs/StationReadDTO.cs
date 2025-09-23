namespace MyFrontend.DTOs
{
    public class StationReadDTO
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public string StationCityName { get; set; }
        public string StationDistrictName { get; set; }
        public int NuberOfPlatforms { get; set; }
    }
}
