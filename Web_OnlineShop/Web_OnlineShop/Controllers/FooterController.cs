using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_OnlineShop.Controllers
{
    public class FooterController : Controller
    {
        //
        // GET: /Footer/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult footer()
        {
            return PartialView();
        }
	}
}