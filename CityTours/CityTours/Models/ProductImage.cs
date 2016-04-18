using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityTours.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Nullable<int> ProductId { get; set; }
    }
}