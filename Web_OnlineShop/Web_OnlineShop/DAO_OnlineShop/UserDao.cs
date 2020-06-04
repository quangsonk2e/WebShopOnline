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
        public List<string> GetListCredential(string userName)
        {
            var user = db.Users.Single(x => x.UserName == userName);
            var data = (from a in db.Credentials
                        join b in db.UserGroups on a.UserGroupID equals b.ID
                        join c in db.Roles on a.RoleID equals c.ID
                        where b.ID == user.GroupID
                        select new
                        {
                            RoleID = a.RoleID,
                            UserGroupID = a.UserGroupID
                        }).AsEnumerable().Select(x => new Credential()
                        {
                            RoleID = x.RoleID,
                            UserGroupID = x.UserGroupID
                        });
            return data.Select(x => x.RoleID).ToList();
        }
        public IEnumerable<User> getUserPage(int pageNumber=1)
        {
            return db.Users.OrderBy(x=>x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public User getById(long id)
        {
            return db.Users.SingleOrDefault(x => x.ID == id);
        }
       
        public User getByUserName(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName==userName);
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
        public int Login(string userName, string password, bool isLoginAdmin = false)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if (result == null) return 0;
            else
            {
                if (isLoginAdmin==true)
                {
                    if (result.GroupID == DEFINE.ADMIN_GROUP)
                    {
                        if (result.Status == false)
                        {
                            return -1;
                        }
                        else
                        {
                            if (result.Password == password)
                                return 1;
                            else
                                return -2;

                        }
                    }
                    else
                        return -3;
                }
                else
                {
                    if (result.Status == false)
                    {
                        return -1;
                    }
                    else
                    {
                        if (result.Password == password)
                            return 1;
                        else
                            return -2;
                    }
                }
            }
        }
    }
}