namespace E_Commerce_API.Data.Models
{
    public class Article
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Content { get; set; }

        public int Reads { get; set; }

        public required string AuthorId { get; set; }
        public virtual required AppUser Author { get; set; }

        public virtual Image? Image { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}