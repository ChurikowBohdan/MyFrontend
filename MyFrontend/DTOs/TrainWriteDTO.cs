using System.ComponentModel.DataAnnotations;

namespace MyFrontend.DTOs
{
    public class TrainWriteDTO
    {
        [Required(ErrorMessage = "Enter train name.")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number of seats must be greater than 0.")]
        public int NumberOfSeats { get; set; }
    }
}