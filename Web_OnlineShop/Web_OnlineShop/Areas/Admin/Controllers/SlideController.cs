using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class SlideController : Controller
    {
        //
        // GET: /Admin/Slide/
        // GET: /Admin/Slide/
        [HttpGet]
        public ActionResult Index()
        {

            return View(new SlideDao().getAll());
        }
        //create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Slide Slide)
        {
            if (ModelState.IsValid)
            {
                new SlideDao().insert(Slide);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Slide Slide)
        {
            if (ModelState.IsValid)
            {
                new SlideDao().update(Slide);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Delete(int ID)
        {
            new SlideDao().delete(ID);
            return RedirectToAction("Index");
        }
	}
}