using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal.Models;

namespace ProjectFinal.Controllers
{
    public class HomeController : Controller
    {
        ClothingShopEntities db = new ClothingShopEntities();

        public ActionResult MyLayout()
        {
            return View();
        }
        public ActionResult getMenu()
        {
            var v = from t in db.menus
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v);
        }
        public ActionResult getBanner() {
            var v = from t in db.banners
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v);
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
        public ActionResult getCategory()
        {
            ViewBag.meta = "san-pham";
            var v = from t in db.categories
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v.ToList());
        }

    }
}