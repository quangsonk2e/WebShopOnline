using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Admin/Menu/
        public ActionResult Index()
        {

            return View(new MenuDao().getAll());
        }
        public ActionResult Edit(int ID)
        {
            return View(new MenuDao().getById(ID));
        }
        [HttpPost]
        public ActionResult Edit(Menu menu)
        {
            if (ModelState.IsValid){
                new MenuDao().update(menu);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int ID)
        {
            new MenuDao().delete(ID);
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Menu menu)
        {
            if(ModelState.IsValid){
                new MenuDao().insert(menu);    
            }
            return RedirectToAction("Index");
        }
	}
}