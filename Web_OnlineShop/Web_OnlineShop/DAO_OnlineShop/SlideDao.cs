using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class SlideDao
    {
         Shop db = null;
        public SlideDao()
        {
            db = new Shop();
        }
        public List<Slide> getAll()
        {
            return db.Slides.ToList();
        }
        public int CountAll()
        {
            return db.Slides.Count();
        }


        public IEnumerable<Slide> getSlidePage(int pageNumber = 1)
        {
            return db.Slides.OrderBy(x => x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSizeProductHome);
        }

       
        public Slide getById(int id)
        {
            return db.Slides.SingleOrDefault(x => x.ID == id);
        }
        public long insert(Slide Slide)
        {
            Slide.CreatedDate = DateTime.Now;
            db.Slides.Add(Slide);
            db.SaveChanges();
            return Slide.ID;
        }
        public int update(Slide Slide)
        {
            var ab = db.Slides.Find(Slide.ID);
            ab.ModifieldDate = DateTime.Now;
            ab.Description = Slide.Description;
            ab.Image = Slide.Image;
            ab.DisplayOrder = Slide.DisplayOrder;
            ab.Link = Slide.Link;
           
            ab.Status = ab.Status;
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        
        public int delete(int id)
        {

            db.Slides.Remove(db.Slides.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}