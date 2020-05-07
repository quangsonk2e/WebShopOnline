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
       
        public IEnumerable<User> getUserPage(int pageNumber=1)
        {
            return db.Users.OrderBy(x=>x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public User getById(long id)
        {
            return db.Users.SingleOrDefault(x => x.ID == id);
        }
        public long insert(User user){
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }
    }
}