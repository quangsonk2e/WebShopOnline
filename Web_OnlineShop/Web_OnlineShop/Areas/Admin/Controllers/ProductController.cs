using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Linq;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Admin/Product/
        public ActionResult Index(int page=1)
        {
            var products = new ProductDao().getProductPage(page);
            return View(products);
        }
        [HttpGet]
        public ActionResult Create(){
            setProductCategory();
            return View();
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Product product)
        {
             if (ModelState.IsValid)
            {
               
                new ProductDao().insert(product);
            }
            
             return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(long id)
        {
            var Model = new ProductDao().getById(id);
            if (Model != null)
                setProductCategory(Model.CategoryID);
            else
                setProductCategory();
                
           return View(Model);
           
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {

                long id = new ProductDao().update(product);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(long id)
        {
            new ProductDao().delete(id);
            return RedirectToAction("Index");
        }
        public void setProductCategory(long? selectedID=null)
        {
            ViewBag.CategoryID = new SelectList(new ProductCategoryDao().getAll(), "ID", "Name", selectedID);
        }
        [HttpPost]
        public JsonResult SaveImages(long id, string images)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var listImages = serializer.Deserialize<List<string>>(images);
            XElement xElement = new XElement("Images");
            foreach (var item in listImages)
            {
                xElement.Add(new XElement("Images", item));

            }
            ProductDao dao = new ProductDao();
            return Json(1);
        }
	}
}