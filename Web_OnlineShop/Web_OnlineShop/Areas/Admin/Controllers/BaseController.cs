﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.Areas.Admin.Models;
using Web_OnlineShop.DAO_OnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Admin/Base/
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
          
           if (Session[DEFINE.USERSESSION]==null)
            filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { controller = "Login", action = "Index", Area = "Admin" }));
            base.OnActionExecuting(filterContext);
        }

       
	}
}