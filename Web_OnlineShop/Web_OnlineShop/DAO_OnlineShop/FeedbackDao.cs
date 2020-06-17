using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_OnlineShop.ModelOnlineShop;
using PagedList;
namespace Web_OnlineShop.DAO_OnlineShop
{
    public class FeedbackDao
    {
         Shop db = null;
        public FeedbackDao()
        {
            db = new Shop();
        }
        public List<Feedback> getAll()
        {
            return db.Feedbacks.ToList();
        }
        public int CountAll()
        {
            return db.Feedbacks.Count();
        }
        
       
        public IEnumerable<Feedback> getFeedbackPage(int pageNumber = 1)
        {
            return db.Feedbacks.OrderBy(x => x.CreatedDate).ToPagedList(pageNumber, DEFINE.pageSize);
        }
        public Feedback getById(long id)
        {
            return db.Feedbacks.SingleOrDefault(x => x.ID == id);
        }
        public long insert(Feedback Feedback)
        {
            Feedback.CreatedDate = DateTime.Now;
            db.Feedbacks.Add(Feedback);
            db.SaveChanges();
            return Feedback.ID;
        }
        public long update(Feedback Feedback)
        {
            var us = db.Feedbacks.Find(Feedback.ID);
            us.Name = Feedback.Name;
            us.Name = Feedback.Name;
            us.Phone = Feedback.Phone;
            us.Email = Feedback.Email;
            us.Address = Feedback.Address;
            us.Content = Feedback.Content;

            us.Status = Feedback.Status;
            
            //us.FeedbackName = Feedback.FeedbackName;
            //us.ModifieldDate = DateTime.Now;
            db.SaveChanges();
            return 1;
        }
       
        public long delete(long id)
        {

            db.Feedbacks.Remove(db.Feedbacks.Find(id));
            db.SaveChanges();
            return 1;
        }
    }
}