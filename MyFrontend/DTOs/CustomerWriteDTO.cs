namespace MyFrontend.DTOs
{
    public class CustomerWriteDTO
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Password { get; init; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public DateTime BirthDate { get; set; }
        public int DiscountValue { get; init; }
        public string Email { get; init; }
    }
}
