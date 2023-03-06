using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal.Models;

namespace ProjectFinal.Controllers
{
    public class ProductController : Controller
    {
        ClothingShopEntities db = new ClothingShopEntities();
        // GET: Product
        public ActionResult Index(String meta)
        {
            var v = from t  in db.categories
                    where t.meta == meta
                    select t;
            return View(v.FirstOrDefault());
        }
        public ActionResult getProduct(long id, string meta_title)
        {
            ViewBag.meta = meta_title;
            var v = from t in db.products
                    where t.hide == true && t.category_id == id
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }
        public ActionResult ProductDetail (string name)
        {
            var v = from t in db.products
                    where t.hide == true && t.name == name
                    select t;
            return View(v.FirstOrDefault());
        }

    }
}