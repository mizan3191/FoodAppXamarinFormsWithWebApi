using System.Collections.Generic;

namespace Food_Web_API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public double Price { get; set; }
        public bool IsPopular { get; set; }
        public int CaregoryId { get; set; }
        public IList<OrderDetails> OrderDetails { get; set; }
        public IList<Cart> Carts { get; set; }
    }
}