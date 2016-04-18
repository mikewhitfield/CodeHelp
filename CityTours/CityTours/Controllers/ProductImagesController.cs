using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityTours.Data;
using CityTours.Models;

namespace CityTours.Controllers
{
    public class ProductImagesController : Controller
    {
        private ToursContainer db = new ToursContainer();

        // GET: ProductImages
        public ActionResult ProdDetails()
        {
            
            return View();
        }

        // GET: ProductImages/Details/5
        public ActionResult Details(int id)
        {
            var ProductThumbs = from x in db.ProductImages
                                 where x.ProductId == id
                                 select new Models.ProductImage
                                 {
                                     Id = x.Id,
                                     ProductId = x.ProductId,
                                     Url = x.Url
                                 };
            return View(ProductThumbs);
        }

        // GET: ProductImages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductImages/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductImages/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductImages/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductImages/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductImages/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
