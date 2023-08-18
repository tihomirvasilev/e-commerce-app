namespace E_Commerce_API.Data.Models
{
    public class ShoppingCartProduct
    {
        public int ShoppingCartId { get; set; }
        public required virtual ShoppingCart ShoppingCart { get; set; }

        public int ProductId { get; set; }
        public required virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}