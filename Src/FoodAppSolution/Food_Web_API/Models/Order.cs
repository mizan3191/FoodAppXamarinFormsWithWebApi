using System;
using System.Collections.Generic;

namespace Food_Web_API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Total { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsComplete { get; set; }
        public IList<OrderDetails> OrderDetails { get; set; }
    }
}