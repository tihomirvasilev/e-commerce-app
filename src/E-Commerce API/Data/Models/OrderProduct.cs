﻿namespace E_Commerce_API.Data.Models
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public required virtual Order Order { get; set; }

        public int ProductId { get; set; }
        public required virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}