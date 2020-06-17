using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class ContentTagDao
    {
         Shop db = null;
        public ContentTagDao()
        {
            db = new Shop();
        }
        public List<ContentTag> getAll()
        {
            return db.ContentTags.ToList();
        }
        public int CountAll()
        {
            return db.ContentTags.Count();
        }


        public IEnumerable<ContentTag> getContentTagPage(int pageNumber = 1)
        {
            return db.ContentTags.OrderBy(x => x.ContentID).ToPagedList(pageNumber, DEFINE.pageSizeProductHome);
        }

       
      
        public long insert(ContentTag ContentTag)
        {
           
            db.ContentTags.Add(ContentTag);
            db.SaveChanges();
            return 1;
        }
        public int update(ContentTag ContentTag)
        {
            var ab = db.ContentTags.Find(ContentTag.ContentID);
            
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        
        public int delete(long ContentID)
        {

            db.ContentTags.Remove(db.ContentTags.Find(ContentID));
            db.SaveChanges();
            return 1;
        }
    }
}