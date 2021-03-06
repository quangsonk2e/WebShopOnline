﻿using System;
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
        public ActionResult Delete(int id)
        {
            new FooterDao().delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var Model = new FooterDao().getById(id);
            return View(Model);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(Footer footer)
        {
            if (ModelState.IsValid)
            {

                long id = new FooterDao().update(footer);
            }
            return RedirectToAction("Index");
        }
	}
}