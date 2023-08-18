using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Net;

namespace E_Commerce_API.Data.Models
{
    public class AppUser
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int ShoppingCartId { get; set; }
        public virtual required ShoppingCart ShoppingCart { get; set; }

        public virtual ICollection<FavoriteProduct> FavoriteProducts { get; set; } = new List<FavoriteProduct>();

        public virtual ICollection<ProductReview> Reviews { get; set; } = new List<ProductReview>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        public virtual ICollection<AppUserAddress> Addresses { get; set; } = new List<AppUserAddress>();

        public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    }
}
