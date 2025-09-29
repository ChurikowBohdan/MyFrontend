namespace MyFrontend.DTOs
{
    public class TrainReadDTO
    {
        public int TrainId { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
