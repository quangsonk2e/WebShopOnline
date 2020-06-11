using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_OnlineShop.DAO_OnlineShop;
using Web_OnlineShop.Models;

namespace Web_OnlineShop.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        //
        // GET: /Cart/
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        public ActionResult AddItem(long productId, int quanttity)
        {
            var Product = new ProductDao().getById(productId);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.product.ID == productId))
                {
                    foreach (var item in list)
                    {
                        if (item.product.ID == productId)
                        {
                            item.Quantity += quanttity;
                        }
                        
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.product = Product;
                    item.Quantity = quanttity;
                    list.Add(item);
                }

            }
            else
            {
                var item = new CartItem();
                item.product = Product;
                item.Quantity = quanttity;
                var list = new List<CartItem>();
                list.Add(item);
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
	}
}