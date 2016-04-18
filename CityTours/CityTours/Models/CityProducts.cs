using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityTours.Models
{
    public class CityProducts
    {
        public int Id { get; set; }
        public string TourName { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> TourPrice { get; set; }
        public string TourImage { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public string CatTourName { get; set; }
        public string Marker { get; set; }
    }
}