using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using finalCNNet;
using System.Web.Mvc;
using finalCNNet.Models;

namespace finalCNNet.Controllers
{
    public class GetMenuController : Controller
    {
        shopOnlineEntities _db = new shopOnlineEntities();
        // GET: GetMenu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getMenu()
        {
            var v = from t in _db.menus
                    where t.hide == true
                    orderby t.order ascending
                    select t;
            return PartialView(v);
        }
    }
}