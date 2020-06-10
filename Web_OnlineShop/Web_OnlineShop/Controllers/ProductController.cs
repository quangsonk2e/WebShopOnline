using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;

namespace Web_OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index(long category=1, int page=1)
        {
            var lsProduct = new ProductDao().getProductCategoryPage(page, category);
            ViewBag.category = category;
            return View(lsProduct);
        }
        
        public ActionResult productByCategory(long id=0){
            var lsProduct = new ProductDao().getProductCategory(id);
            return PartialView(lsProduct);
        }
        public ActionResult Top4Category()
        {
          
            return PartialView();
        }
        public ActionResult recommendProduct()
        {

            return PartialView();
        }
	}
}