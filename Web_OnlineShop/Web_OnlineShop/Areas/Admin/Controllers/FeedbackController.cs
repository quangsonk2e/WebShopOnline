using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class FeedbackController : Controller
    {
        //
        // GET: /Admin/Feedback/
        // GET: /Admin/Feedback/
        [HttpGet]
        public ActionResult Index()
        {

            return View(new FeedbackDao().getAll());
        }
        //create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Feedback Feedback)
        {
            if (ModelState.IsValid)
            {
                new FeedbackDao().insert(Feedback);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Feedback Feedback)
        {
            if (ModelState.IsValid)
            {
                new FeedbackDao().update(Feedback);
            }
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Delete(int ID)
        {
            new FeedbackDao().delete(ID);
            return RedirectToAction("Index");
        }
	}
}