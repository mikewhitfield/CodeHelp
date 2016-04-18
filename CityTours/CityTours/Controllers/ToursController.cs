using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityTours.Data;
using CityTours.Models;

namespace CityTours.Controllers
{
    public class ToursController : Controller
    {
        private ToursContainer db = new ToursContainer();

        // GET: Tours
        public ActionResult Index()
        {
            var Products = from e in db.Products
                           join c in db.Categories
                           on e.CategoryId equals c.Id
                           select new CityProducts
                           {
                               Id = e.Id,
                               CatTourName = c.Name,
                               TourImage = e.ImageUrl,
                               TourName = e.Name,
                               Latitude = e.Latitude,
                               Longitude = e.Longitude,
                               Icon = e.Marker,
                               TourPrice = e.Price,
                               Summary = e.Summary
                           };
            return View(Products);
        }

        // Show JSON
        public ActionResult myResults()
        {
            var Products = from e in db.Products
                           join c in db.Categories
                           on e.CategoryId equals c.Id
                           select new CityProducts
                           {
                               Id = e.Id,
                               CatTourName = c.Name,
                               TourImage = e.ImageUrl,
                               TourName = e.Name,
                               Latitude = e.Latitude,
                               Longitude = e.Longitude,
                               Icon = e.Marker,
                               TourPrice = e.Price,
                               Summary = e.Summary,
                               Marker = e.Marker
                           };
            return Json(Products,JsonRequestBehavior.AllowGet);
        }


        // GET: Tours/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tours/Create
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

        // GET: Tours/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tours/Edit/5
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

        // GET: Tours/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tours/Delete/5
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
