namespace MyFrontend.DTOs
{
    public class RegistrationDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //public string? RefrestToken { get; set; }
        //public DateTime? RefreshTokenExpiryTime { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
