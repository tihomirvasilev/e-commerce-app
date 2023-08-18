namespace E_Commerce_API.Data.Models
{
    public class Image
    {
        public int Id { get; set; }

        public required string ImageUrl { get; set; }

        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }

        public int? ArticleId { get; set; }
        public virtual Article? Article { get; set; }
    }
}