namespace E_Commerce_API.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        public int MainCategoryId { get; set; }
        public virtual required MainCategory MainCategory { get; set; }
    }
}
