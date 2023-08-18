using System.Diagnostics.Metrics;
using System.Net;

namespace E_Commerce_API.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ExpectedDeliveryDate { get; set; }

        public DateTime? ShippingDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal DeliveryPrice { get; set; }

        public required string Recipient { get; set; }

        public required string RecipientPhoneNumber { get; set; }

        public int PaymentMethodId { get; set; }
        public required virtual PaymentMethod PaymentMethod { get; set; }

        public int OrderStatusId { get; set; }
        public required virtual OrderStatus OrderStatus { get; set; }

        public int PaymentStatusId { get; set; }
        public required virtual PaymentStatus PaymentStatus { get; set; }

        public int AddressId { get; set; }
        public required virtual AppUserAddress DeliveryAddress { get; set; }

        public int CourierId { get; set; }
        public required virtual Courier Courier { get; set; }

        public required string AppUserId { get; set; }
        public required virtual AppUser AppUser { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}