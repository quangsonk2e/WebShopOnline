using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.Areas.Admin.Models;
using Web_OnlineShop.DAO_OnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Admin/Login/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {

            if (ModelState.IsValid)
            {

                Session.Add(DEFINE.USERSESSION, login);
            }
            else
            {
                ModelState.AddModelError("", "Lỗi không thấy tên đăng nhập");
            }
            return RedirectToAction("Index","Home");
        }
	}
}