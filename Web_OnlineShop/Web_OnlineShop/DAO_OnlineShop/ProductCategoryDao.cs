using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class ProductCategoryDao
    {
        Shop db = null;
        public ProductCategoryDao()
        {
            db = new Shop();
        }
        public List<ProductCategory> getAll()
        {
            return db.ProductCategories.ToList();
        }
        public List<ProductCategory> getAllParent(long? idParent=0)
        {
            if (idParent == -1) return db.ProductCategories.Where(x => x.ParentID != 0).ToList();
            return db.ProductCategories.Where(x => x.ParentID == idParent).ToList();
        }
       
        public int CountAll()
        {
            return db.ProductCategories.Count();
        }

        public IEnumerable<ProductCategory> getProductCategoryPage(int pageNumber = 1)
        {
            return db.ProductCategories.OrderBy(x => x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public ProductCategory getById(long id)
        {
            return db.ProductCategories.SingleOrDefault(x => x.ID == id);
        }
        public long insert(ProductCategory productCategory)
        {
            db.ProductCategories.Add(productCategory);
            db.SaveChanges();
            return productCategory.ID;
        }
        public long update(ProductCategory productCategory)
        {
            var pc = db.ProductCategories.Find(productCategory.ID);
            pc.Name = productCategory.Name;
            pc.MetaDescriptions = productCategory.MetaDescriptions;
            pc.MetaKeywords = productCategory.MetaKeywords;
            pc.MetaTitle = productCategory.MetaTitle;
            pc.ParentID = productCategory.ParentID;
            pc.SeoTitle = productCategory.SeoTitle;
            pc.ShowOnHome = productCategory.ShowOnHome;
            pc.Status = productCategory.Status;
            pc.ModifieldDate = DateTime.Now;
            //us.UserName = user.UserName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        public long delete(long id)
        {

            db.ProductCategories.Remove(db.ProductCategories.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}