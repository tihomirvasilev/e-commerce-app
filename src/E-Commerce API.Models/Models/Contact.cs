namespace E_Commerce_API.Data.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public required string ContactorFirstName { get; set; }

        public required string ContactorLastName { get; set; }

        public required string Email { get; set; }

        public required string Phone { get; set; }

        public required string Message { get; set; }

        public bool IsArchived { get; set; }

        public bool IsReaded { get; set; }
    }
}
