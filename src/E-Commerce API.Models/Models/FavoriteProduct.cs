namespace E_Commerce_API.Data.Models
{
    public class FavoriteProduct
    {
        public string AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}