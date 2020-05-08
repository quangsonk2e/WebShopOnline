using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using PagedList;
using PagedList.Mvc;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /Admin/User/
        public ActionResult Index(int page=1)
        {
            var Model = new UserDao().getUserPage(page);
            return View(Model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.Password = Helper.MD5Hash(user.Password);
                new UserDao().insert(user);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(long id){
            var Model = new UserDao().getById(id);
            return View(Model);
        }
        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
            user.Password = Helper.MD5Hash(user.Password);
            long id=new UserDao().update(user);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(long id)
        {
            new UserDao().delete(id);
            return RedirectToAction("Index");
        }
	}
}