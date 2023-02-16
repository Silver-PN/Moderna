using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace final_project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: HomePage
        public ActionResult Default()
        {
            return View();
        }
    }
}