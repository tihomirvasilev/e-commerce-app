namespace E_Commerce_API.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public required string ProductName { get; set; }

        public int ProductCategoryId { get; set; }
        public required virtual Category ProductCategory { get; set; }

        public int MakerId { get; set; }
        public required virtual Maker Maker { get; set; }

        public virtual ICollection<Image> ProductImages { get; set; } = new List<Image>();

        public string? Description { get; set; }

        public string? ManualUrl { get; set; }

        public int Warranty { get; set; }

        public decimal Price { get; set; }

        public int QuantityInStock { get; set; }

        public int Rating { get; set; }

        public int SalesCount { get; set; }

        public bool IsOutOfStock { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<ProductReview> UserReviews { get; set; } = new List<ProductReview>();
    }
}