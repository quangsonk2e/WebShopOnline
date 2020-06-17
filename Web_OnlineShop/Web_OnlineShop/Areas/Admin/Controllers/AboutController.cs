using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /Admin/About/
        public ActionResult Index()
        {

            return View(new AboutDao().getAll());
        }
        //create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(About about)
        {
            if (ModelState.IsValid){
                new AboutDao().insert(about);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Edit()
        {
            return View();
        }
         [HttpPost]
        public ActionResult Edit(About about)
        {
            if (ModelState.IsValid)
            {
                new AboutDao().update(about);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Delete(int ID)
        {
            new AboutDao().delete(ID);
            return RedirectToAction("Index");
        }
	}
}