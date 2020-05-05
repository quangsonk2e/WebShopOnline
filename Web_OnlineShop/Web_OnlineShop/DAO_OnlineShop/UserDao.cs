using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;

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
        public User getById(int id)
        {
            return db.Users.SingleOrDefault(x => x.ID == id);
        }
    }
}