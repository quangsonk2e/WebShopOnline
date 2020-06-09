using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class ProductCategoryController : Controller
    {
        //
        // GET: /Admin/ProductCategory/
        public ActionResult Index()
        {
            var productCategorys = new ProductCategoryDao().getAll();
            return View(productCategorys);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(ProductCategory ProductCategory)
        {
            new ProductCategoryDao().insert(ProductCategory);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            new ProductCategoryDao().delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var Model = new ProductCategoryDao().getById(id);
            return View(Model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(ProductCategory ProductCategory)
        {
            if (ModelState.IsValid)
            {

                long id = new ProductCategoryDao().update(ProductCategory);
            }
            return RedirectToAction("Index");
        }
        public void setCategoryParent(long? selectedID = null)
        {
            ViewBag.CategoryID = new SelectList(new ProductCategoryDao().getAllParent(), "ID", "Name", selectedID);
        }

	}
}