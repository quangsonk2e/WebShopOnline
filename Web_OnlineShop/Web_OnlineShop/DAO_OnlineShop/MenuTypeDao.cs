using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class MenuTypeDao
    {
         Shop db = null;
        public MenuTypeDao()
        {
            db = new Shop();
        }
        public List<MenuType> getAll()
        {
            return db.MenuTypes.ToList();
        }
        public int CountAll()
        {
            return db.MenuTypes.Count();
        }


        
       
        public MenuType getById(int id)
        {
            return db.MenuTypes.SingleOrDefault(x => x.ID == id);
        }
        public long insert(MenuType MenuType)
        {
           
            db.MenuTypes.Add(MenuType);
            db.SaveChanges();
            return MenuType.ID;
        }
        public int update(MenuType MenuType)
        {
            var ab = db.MenuTypes.Find(MenuType.ID);
           
            ab.Name = ab.Name;
            
            //us.ProductName = Product.ProductName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
        
        public int delete(int id)
        {

            db.MenuTypes.Remove(db.MenuTypes.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}