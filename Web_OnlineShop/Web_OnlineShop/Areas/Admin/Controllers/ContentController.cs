using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        //
        // GET: /Admin/Content/
        // GET: /Admin/Content/
        [HttpGet]
        public ActionResult Index()
        {

            return View(new ContentDao().getAll());
        }
        //create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Content Content)
        {
            if (ModelState.IsValid)
            {
                new ContentDao().insert(Content);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Content Content)
        {
            if (ModelState.IsValid)
            {
                new ContentDao().update(Content);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Delete(int ID)
        {
            new ContentDao().delete(ID);
            return RedirectToAction("Index");
        }
	}
}