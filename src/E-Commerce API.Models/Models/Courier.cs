namespace E_Commerce_API.Data.Models
{
    public class Courier
    {
        public int Id { get; set; }

        public required string CourierName { get; set; }

        public decimal PriceToOffice { get; set; }

        public decimal PriceToAddress { get; set; }

        public int DeliveryTimeInDays { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}