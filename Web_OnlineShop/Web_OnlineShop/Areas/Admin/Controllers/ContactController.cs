using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Admin/Contact/
        // GET: /Admin/Contact/
        [HttpGet]
        public ActionResult Index()
        {

            return View(new ContactDao().getAll());
        }
        //create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact Contact)
        {
            if (ModelState.IsValid)
            {
                new ContactDao().insert(Contact);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Contact Contact)
        {
            if (ModelState.IsValid)
            {
                new ContactDao().update(Contact);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Delete(int ID)
        {
            new ContactDao().delete(ID);
            return RedirectToAction("Index");
        }
	}
}