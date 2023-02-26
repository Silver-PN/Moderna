using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectFinal.Models;

namespace ProjectFinal.Controllers
{
    public class MenuController : Controller
    {
        ClothingShopEntities db = new ClothingShopEntities();
        // GET: Menu
        public ActionResult Index()
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
    }
}