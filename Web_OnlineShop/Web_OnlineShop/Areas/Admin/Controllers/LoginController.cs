using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.Models;

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
                var dao = new UserDao();
                var result = dao.Login(login.UserName, Helper.MD5Hash(login.Password), true);
                if(result==1)
                {
                    var user = dao.getByUserName(login.UserName);
                    var userSession = new LoginViewModel();
                    userSession.UserName = user.UserName;
                    userSession.Password = user.Password;
                    userSession.GroupID = user.GroupID;
                    var lisCredentials = dao.GetListCredential(login.UserName);
                    Session.Add(DEFINE.CREDENTIAL_SESSION, lisCredentials);
                    Session.Add(DEFINE.USERSESSION, userSession);
                    return RedirectToAction("Index", "Home");

                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tai khoanr khong ton tai");
                }
                else if(result==-1)
                {
                    ModelState.AddModelError("", "Tai khoan bi khoa");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mat khau khong dung");

                }
                else if (result == -3)
                {
                    ModelState.AddModelError("", "Tai khoan cua ban khong cos quyen dang nhap");
                }
                else
                {
                    ModelState.AddModelError("", "Dang nhap ko dung");
                }

            }

            return View("Index");
        }
	}
}