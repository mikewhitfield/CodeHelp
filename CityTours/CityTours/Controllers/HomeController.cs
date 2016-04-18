using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityTours.Data;
using CityTours.Models;

namespace CityTours.Controllers
{
    

    public class HomeController : Controller
    {
        private ToursContainer db = new ToursContainer();

        public ActionResult Index()
        {
            var MyModel = from e in db.Featureds
                        join p in db.Products
                        on e.ProductId equals p.Id
                        join c in db.Categories
                        on p.CategoryId equals c.Id
                        select new FeaturedProduct
                        {
                            Id = e.Id,
                            ProductId = e.Id,
                            CatagoryName = c.Name,
                            ImageUrl = p.ImageUrl,
                            Name = p.Name,
                            Latitude = p.Latitude,
                            Longitude = p.Longitude,
                            Price = p.Price,
                            Summary = p.Summary,
                            ProdId = p.Id
                        };

            return View(MyModel);
        }

    }
}