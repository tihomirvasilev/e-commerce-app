namespace E_Commerce_API.Data.Models
{
    public class Maker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string OfficialSite { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
