using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class ProductDao
    {
        Shop db = null;
        public ProductDao()
        {
            db = new Shop();
        }
        public List<Product> getAll()
        {
            return db.Products.ToList();
        }
        public int CountAll()
        {
            return db.Products.Count();
        }

        public IEnumerable<Product> getProductPage(int pageNumber = 1)
        {
            return db.Products.OrderBy(x => x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public Product getById(long id)
        {
            return db.Products.SingleOrDefault(x => x.ID == id);
        }
        public long insert(Product Product)
        {
            Product.CreatedDate = DateTime.Now;
            db.Products.Add(Product);
            db.SaveChanges();
            return Product.ID;
        }
        public long update(Product Product)
        {
            var us = db.Products.Find(Product.ID);
            us.Name = Product.Name;
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        public long delete(long id)
        {

            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}