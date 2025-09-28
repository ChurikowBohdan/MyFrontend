using System.ComponentModel.DataAnnotations;

namespace MyFrontend.DTOs
{ 
    public class StationWriteDTO
    {
        [Required(ErrorMessage = "Enter station name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter station city name.")]
        public string StationCityName { get; set; }

        [Required(ErrorMessage = "Enter station district name.")]
        public string StationDistrictName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number of platforms must be greater than 0.")]
        public int NumberOfPlatforms { get; set; }
    }
}
