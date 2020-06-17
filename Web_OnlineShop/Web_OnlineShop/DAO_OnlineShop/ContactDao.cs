using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class ContactDao
    {
         Shop db = null;
        public ContactDao()
        {
            db = new Shop();
        }
        public List<Contact> getAll()
        {
            return db.Contacts.ToList();
        }
        public int CountAll()
        {
            return db.Contacts.Count();
        }


        public IEnumerable<Contact> getContactPage(int pageNumber = 1)
        {
            return db.Contacts.OrderBy(x => x.ID).ToPagedList(pageNumber, DEFINE.pageSizeProductHome);
        }

       
        public Contact getById(long id)
        {
            return db.Contacts.SingleOrDefault(x => x.ID == id);
        }
        public long insert(Contact Contact)
        {
           
            db.Contacts.Add(Contact);
            db.SaveChanges();
            return Contact.ID;
        }
        public int update(Contact Contact)
        {
            var ct = db.Contacts.Find(Contact.ID);
            ct.Content = Contact.Content;
            ct.Status = Contact.Status;
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        
        public int delete(long id)
        {

            db.Contacts.Remove(db.Contacts.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}