using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using PagedList;
using PagedList.Mvc;

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
	}
}