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
            user.CreatedDate = DateTime.Now;
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }
        public long update(User user)
        {
            var us = db.Users.Find(user.ID);
            us.ModifieldDate = DateTime.Now;
            us.Name = user.Name;
            us.UserName = user.UserName;
            us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        public long delete(long id)
        {

            db.Users.Remove(db.Users.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}