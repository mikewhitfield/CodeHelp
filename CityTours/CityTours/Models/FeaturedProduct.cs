using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityTours.Models
{
    public class FeaturedProduct
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string CatagoryName { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Summary { get; set; }
        public int ProdId { get; set; }
    }
}