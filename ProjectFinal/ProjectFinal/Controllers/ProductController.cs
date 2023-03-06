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
        public ActionResult ProductDetail (string name)
        {
            var v = from t in db.products
                    where t.hide == true && t.name == name
                    select t;
            return View(v.FirstOrDefault());
        }

    }
}