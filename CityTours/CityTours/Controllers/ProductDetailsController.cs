using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityTours.Data;
using CityTours.Models;

namespace CityTours.Controllers
{
    public class ProductDetailsController : Controller
    {
        private ToursContainer db = new ToursContainer();

        // GET: ProductDetails
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductDetails/Details/5
        public ActionResult Details(int id)
        {
            Product Detail = db.Products.Find(id);

            return View(Detail);
        }

        // GET: ProductDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductDetails/Create
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

        // GET: ProductDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductDetails/Edit/5
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

        // GET: ProductDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductDetails/Delete/5
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
