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
        public IEnumerable<Product> Top4Category(int top, long categoryID)
        {
            return db.Products.Where(x => x.CategoryID == categoryID).Skip(0).Take(4).ToList();
        }
        public IEnumerable<Product> getProductCategory(long categoryID = 0)
        {
            return db.Products.Where(x => x.CategoryID == categoryID).ToList();
        }
        public IEnumerable<Product> getProductCategoryPage(int pageNumber = 1, long categoryID=0)
        {
            return db.Products.Where(x => x.CategoryID == categoryID).OrderBy(x=>x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
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
            us.CategoryID = Product.CategoryID;
            us.Code = Product.Code;
            us.Description = Product.Description;
            us.Detail = Product.Detail;
            us.Image = Product.Image;
            us.IncludeVAT = Product.IncludeVAT;
            us.MetaDescriptions = Product.MetaDescriptions;
            us.MetaKeywords = Product.MetaKeywords;
            us.MetaTitle = Product.MetaTitle;
            us.MoreImages = Product.MoreImages;
            us.Price = Product.Price;
            us.PromotionPrice = Product.PromotionPrice;
            us.Quantity = Product.Quantity;
            us.Status = Product.Status;
            us.TopHot = Product.TopHot;
            us.Warranty = Product.Warranty;
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        public long updateImages(long id, string Images)
        {
            var product = db.Products.Find(id);
            product.MoreImages = Images;
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