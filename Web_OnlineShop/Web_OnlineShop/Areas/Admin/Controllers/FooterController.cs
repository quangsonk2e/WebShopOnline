using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class FooterController : Controller
    {
        //
        // GET: /Admin/Footer/
        public ActionResult Index()
        {
            var footers = new FooterDao().getAll();
            return View(footers);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Footer footer)
        {
            new FooterDao().insert(footer);
            return RedirectToAction("Index");
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
	}
}