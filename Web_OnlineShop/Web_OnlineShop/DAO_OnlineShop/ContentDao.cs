using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class ContentDao
    {
         Shop db = null;
        public ContentDao()
        {
            db = new Shop();
        }
        public List<Content> getAll()
        {
            return db.Contents.ToList();
        }
        public int CountAll()
        {
            return db.Contents.Count();
        }
        
        public IEnumerable<Content> getContentCategoryPage(int pageNumber = 1, long categoryID=0)
        {
            return db.Contents.Where(x => x.CategoryID == categoryID).OrderBy(x=>x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
        }

        public IEnumerable<Content> getContentPage(int pageNumber = 1)
        {
            return db.Contents.OrderBy(x => x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public Content getById(long id)
        {
            return db.Contents.SingleOrDefault(x => x.ID == id);
        }
        public long insert(Content Content)
        {
            Content.CreatedDate = DateTime.Now;
            db.Contents.Add(Content);
            db.SaveChanges();
            return Content.ID;
        }
        public long update(Content Content)
        {
            var us = db.Contents.Find(Content.ID);
            us.Name = Content.Name;
            us.CategoryID = Content.CategoryID;
            
            us.Description = Content.Description;
            us.Detail = Content.Detail;
            us.Image = Content.Image;
           
            us.MetaDescriptions = Content.MetaDescriptions;
            us.MetaKeywords = Content.MetaKeywords;
            us.MetaTitle = Content.MetaTitle;
           
            us.Status = Content.Status;
            us.TopHot = Content.TopHot;
            us.ViewCount = Content.ViewCount;
            //us.ContentName = Content.ContentName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
      
        public long delete(long id)
        {

            db.Contents.Remove(db.Contents.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}