using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityTours.Models
{
    public class CartItems
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> CartId { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
    }
}