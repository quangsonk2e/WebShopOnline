using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class AboutDao
    {
        Shop db = null;
        public AboutDao()
        {
            db = new Shop();
        }
        public List<About> getAll()
        {
            return db.Abouts.ToList();
        }
        public int CountAll()
        {
            return db.Abouts.Count();
        }


        public IEnumerable<About> getAboutPage(int pageNumber = 1)
        {
            return db.Abouts.OrderBy(x => x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSizeProductHome);
        }

       
        public About getById(int id)
        {
            return db.Abouts.SingleOrDefault(x => x.ID == id);
        }
        public long insert(About About)
        {
            About.CreatedDate = DateTime.Now;
            db.Abouts.Add(About);
            db.SaveChanges();
            return About.ID;
        }
        public int update(About About)
        {
            var ab = db.Abouts.Find(About.ID);
            ab.ModifieldDate = DateTime.Now;
            ab.Description = About.Description;
            ab.Detail = About.Detail;
            ab.MetaDescriptions = About.MetaDescriptions;
            ab.MetaKeywords = About.MetaKeywords;
            ab.MetaTitle = About.MetaTitle;
            ab.Name = ab.Name;
            ab.Status = ab.Status;
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        
        public int delete(int id)
        {

            db.Abouts.Remove(db.Abouts.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}