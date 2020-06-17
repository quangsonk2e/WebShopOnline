using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Admin/Category/
        // GET: /Admin/About/
        [HttpGet]
        public ActionResult Index()
        {

            return View(new CategoryDao().getAll());
        }
        //create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category Category)
        {
            if (ModelState.IsValid)
            {
                new CategoryDao().insert(Category);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Category Category)
        {
            if (ModelState.IsValid)
            {
                new CategoryDao().update(Category);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Delete(long ID)
        {
            new CategoryDao().delete(ID);
            return RedirectToAction("Index");
        }
	}
}