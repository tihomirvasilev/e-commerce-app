namespace E_Commerce_API.Data.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }

        public required string PaymentMethodName { get; set; }
    }
}