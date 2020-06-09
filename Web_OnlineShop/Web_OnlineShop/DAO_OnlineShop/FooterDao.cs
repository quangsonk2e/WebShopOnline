using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;

namespace Web_OnlineShop.DAO_OnlineShop
{
    public class FooterDao
    {
        Shop db = null;
        public FooterDao()
        {
            db = new Shop();
        }
        public List<Footer> getAll()
        {
            return db.Footers.ToList();
        }
        public int CountAll()
        {
            return db.Footers.Count();
        }
        public IEnumerable<Footer> getFooterPage(int pageNumber = 1)
        {
            return db.Footers.OrderBy(x => x.ID).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public Footer getById(long id)
        {
            return db.Footers.SingleOrDefault(x => x.ID == id);
        }
       
        //public User getByUserName(string userName)
        //{
        //    return db.Users.SingleOrDefault(x => x.UserName==userName);
        //}
        public long insert(Footer footer){

            db.Footers.Add(footer);
            db.SaveChanges();
            return footer.ID;
        }
        public long update(Footer footer)
        {
            var ft = db.Footers.Find(footer.ID);

            ft.Status = footer.Status;
            ft.Content = footer.Content;
            db.SaveChanges();
            return 1;
        }
        public long delete(long id)
        {

            db.Footers.Remove(db.Footers.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}