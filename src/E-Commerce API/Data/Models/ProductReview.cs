namespace E_Commerce_API.Data.Models
{
    public class ProductReview
    {
        public int Id { get; set; }

        public required string AppUserId { get; set; }
        public required virtual AppUser AppUser { get; set; }

        public int ProductId { get; set; }
        public required virtual Product Product { get; set; }

        public required string Comment { get; set; }

        public double Rating { get; set; }
    }
}