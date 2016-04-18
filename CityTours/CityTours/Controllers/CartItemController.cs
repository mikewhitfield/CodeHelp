using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityTours.Data;
using CityTours.Models;

namespace CityTours.Controllers
{
    public class CartItemController : Controller
    {
        private ToursContainer db = new ToursContainer();

        // GET: CartItem
        public ActionResult Index()
        {
            var CartItems = from p in db.Products
                             join c in db.CartItems
                             on p.Id equals c.ProductId
                             select new CartItems
                             {
                                 Id = c.Id,
                                 ImageUrl = p.ImageUrl,
                                 ProductName = p.Name,
                                 Total = c.Total
                             };
            return View(CartItems);
        }

        // GET: CartItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartItem/Create
        public ActionResult Create()
        {
            //db.CartItems.Add(new CartItem(){   
            //                    ProductId = productId,
            //                    Total = total
            //                    });
            //db.SaveChanges();
            //return RedirectToAction("Details", "ProductDetails", new { id = productId });
            return View();
        }

        // POST: CartItem/Create
        [HttpPost]
        public ActionResult Create(int total, int productId)
        {
            try
            {
                // TODO: Add insert logic here
                db.CartItems.Add(new CartItem()
                {
                    ProductId = productId,
                    Total = total
                });
                db.SaveChanges();
                return RedirectToAction("Details", "ProductDetails", new { id = productId });

                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CartItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartItem/Edit/5
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

        // GET: CartItem/Delete/5
        public ActionResult Delete(/*int id*/)
        {
            return View();
        }

        // POST: CartItem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id )
        {
            try
            {
                // TODO: Add delete logic here
                CartItem cartItem = db.CartItems.Find(id);
                if (cartItem == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                db.CartItems.Remove(cartItem);
                db.SaveChanges();
                return RedirectToAction("Index", "CartItem");
            }
            catch
            {
                return View();
            }
        }
    }
}
