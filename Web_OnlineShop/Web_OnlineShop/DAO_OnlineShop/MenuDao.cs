using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class MenuDao
    {
         Shop db = null;
         public MenuDao()
        {
            db = new Shop();
        }
        public List<Menu> getAll()
        {
            return db.Menus.ToList();
        }
        public List<Menu> getMenuByType( int typeId=1)
        {
            return db.Menus.Where(x => x.TypeID == typeId).OrderBy(x => x.DisplayOrder).ToList();
        }
        public int CountAll()
        {
            return db.Menus.Count();
        }
        public IEnumerable<Menu> getMenuPage(int pageNumber = 1)
        {
            return db.Menus.OrderBy(x => x.ID).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public Menu getById(long id)
        {
            return db.Menus.SingleOrDefault(x => x.ID == id);
        }
       
        //public User getByUserName(string userName)
        //{
        //    return db.Users.SingleOrDefault(x => x.UserName==userName);
        //}
        public long insert(Menu Menu){

            db.Menus.Add(Menu);
            db.SaveChanges();
            return Menu.ID;
        }
        public long update(Menu Menu)
        {
            var mn= db.Menus.Find(Menu.ID);
            mn.DisplayOrder = Menu.DisplayOrder;
            mn.Link = Menu.Link;
            mn.Target = Menu.Target;
            mn.Text = Menu.Text;
            mn.TypeID = Menu.TypeID;
            mn.Status = Menu.Status;
          
            db.SaveChanges();
            return 1;
        }
        public long delete(long id)
        {

            db.Menus.Remove(db.Menus.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}