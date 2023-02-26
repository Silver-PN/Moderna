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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getProduct()
        {
            var v = from t in db.products
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v);
        }
    }
}