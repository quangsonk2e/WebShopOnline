using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Admin/Product/
        public ActionResult Index(int page=1)
        {
            var products = new ProductDao().getProductPage(page);
            return View(products);
        }
        [HttpGet]
        public ActionResult Create(){
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {

            return View();
        }
	}
}