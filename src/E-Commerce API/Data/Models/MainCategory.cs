namespace E_Commerce_API.Data.Models
{
    public class MainCategory
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}