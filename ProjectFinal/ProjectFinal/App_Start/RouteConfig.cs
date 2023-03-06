﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectFinal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Product", "{type}/{meta}",
                new { controller = "Product", action = "Index", meta = UrlParameter.Optional },
                new RouteValueDictionary
                {
                    {"type","san-pham" }
                },
                new[] { "ProjectFinal.Controllers" });

            routes.MapRoute("ProductDetail", "{type}/{meta}/{id}/{name}",
                new { controller = "Product", action = "ProductDetail", name = UrlParameter.Optional },
                new RouteValueDictionary
                {
                    {"type","san-pham" }
                },
                new[] { "ProjectFinal.Controllers" });

            routes.MapRoute("HomePage", "{type}/{meta}",
                new { controller = "Home", action = "MyLayout", meta = UrlParameter.Optional },
                new RouteValueDictionary
                {
                    {"type","trang-chu" }
                },
                new[] { "ProjectFinal.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "MyLayout", id = UrlParameter.Optional }
            );
        }
    }
}
