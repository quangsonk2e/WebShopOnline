using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.Models
{
    public class CartItem
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
    }
}