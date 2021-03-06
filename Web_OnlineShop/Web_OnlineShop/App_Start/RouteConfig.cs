﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_OnlineShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Product",
               url: "nhom-{ten}-{category}-{page}",
               defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "Web_OnlineShop.Controllers" }
               );
            routes.MapRoute(
             name: "them hang",
             url: "them-hang-{productId}-{quanttity}",
             defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
             namespaces: new[] { "Web_OnlineShop.Controllers" }
             );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Web_OnlineShop.Controllers" }
            );
        }
    }
}
