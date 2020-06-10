using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MenuCatagory()
        {
            ViewBag.CategorySelect = 1;
            var productCategory = new ProductCategoryDao().getAllParent();
            return PartialView(productCategory);
        }
        public ActionResult Top4Category(int top=4)
        {
            ViewBag.CategorySelect = 1;
            var productCategory = new ProductCategoryDao().getAllParent();
            return PartialView(productCategory);
        }
    }
}