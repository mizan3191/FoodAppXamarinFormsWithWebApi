using System.Collections.Generic;

namespace Food_Web_API.Models
{
    public class Caregory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUri { get; set; } 
        public IList<Product> Products { get; set; }
    }
}