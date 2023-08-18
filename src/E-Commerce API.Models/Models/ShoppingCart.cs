namespace E_Commerce_API.Data.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public required virtual AppUser AppUser { get; set; }

        public virtual ICollection<ShoppingCartProduct> ShoppingCartProducts { get; set; } = new List<ShoppingCartProduct>();
    }
}