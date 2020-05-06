using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;

namespace Web_OnlineShop.DAO_OnlineShop
{
    public class UserDao
    {
        Shop db = null;
        public UserDao()
        {
            db = new Shop();
        }
        public List<User> getAll()
        {
            return db.Users.ToList();
        }
        public int CountAll()
        {
            return db.Users.Count();
        }
       
        public IEnumerable<User> getUserPage(int pageNumber=1, int pageSize=1)
        {
            return db.Users.OrderBy(x=>x.CreatedDate).ToPagedList(pageNumber, pageSize);
        }
        public User getById(int id)
        {
            return db.Users.SingleOrDefault(x => x.ID == id);
        }
    }
}