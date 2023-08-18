namespace E_Commerce_API.Data.Models
{
    public class AppUserAddress
    {
        public int Id { get; set; }

        public required string TechAndToolsUserId { get; set; }

        public required string City { get; set; }

        public required string Address { get; set; }

        public int PostCode { get; set; }
    }
}