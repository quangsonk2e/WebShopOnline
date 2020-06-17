using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;

namespace Web_OnlineShop.DAO_OnlineShop
{
    public class CategoryDao
    {
         Shop db = null;
        public CategoryDao()
        {
            db = new Shop();
        }
        public List<Category> getAll()
        {
            return db.Categories.ToList();
        }
        public int CountAll()
        {
            return db.Categories.Count();
        }


        public IEnumerable<Category> getCategoryPage(int pageNumber = 1)
        {
            return db.Categories.OrderBy(x => x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSizeProductHome);
        }

       
        public Category getById(int id)
        {
            return db.Categories.SingleOrDefault(x => x.ID == id);
        }
        public long insert(Category Category)
        {
            Category.CreatedDate = DateTime.Now;
            db.Categories.Add(Category);
            db.SaveChanges();
            return Category.ID;
        }
        public int update(Category Category)
        {
            var ab = db.Categories.Find(Category.ID);

            ab.ModifieldDate = DateTime.Now;
            ab.ParentID = Category.ParentID;
            ab.SeoTitle = Category.SeoTitle;
            ab.ShowOnHome = Category.ShowOnHome;
            ab.MetaDescriptions = Category.MetaDescriptions;
            ab.MetaKeywords = Category.MetaKeywords;
            ab.MetaTitle = Category.MetaTitle;
            ab.Name = ab.Name;
            ab.Status = ab.Status;
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        
        public int delete(int id)
        {

            db.Categories.Remove(db.Categories.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}