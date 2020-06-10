using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;

namespace Web_OnlineShop.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult mainMenu()
        {
            var lsMenu = new MenuDao().getMenuByType(1);
            return PartialView(lsMenu);
        }
	}
}