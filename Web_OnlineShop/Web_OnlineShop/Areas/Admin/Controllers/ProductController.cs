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
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Product product)
        {
             if (ModelState.IsValid)
            {
                new ProductDao().insert(product);
            }
             return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(long id)
        {
            var Model = new UserDao().getById(id);
            return View(Model);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {

                long id = new ProductDao().update(product);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(long id)
        {
            new ProductDao().delete(id);
            return RedirectToAction("Index");
        }
	}
}