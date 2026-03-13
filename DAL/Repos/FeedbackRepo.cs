using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TourAndTravel.DAL.Models;

namespace DAL.Repos
{
    internal class FeedbackRepo : IRepo<Feedback, string, int >
    {
        private readonly TourAndTravelContext db;

        public FeedbackRepo(TourAndTravelContext context)
        {
            db = context;
        }

        public FeedbackRepo()
        {
        }

        public Feedback Create(Feedback entity)
        {
            db.Feedbacks.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public IEnumerable<Feedback> ReadAll()
        {
            return db.Feedbacks.ToList();
        }

        public Feedback ReadById(int id)
        {
            return db.Feedbacks.Find(id);
        }

        public IEnumerable<Feedback> ReadWhere(Expression<Func<Feedback, bool>> predicate)
        {
            return db.Feedbacks.Where(predicate).ToList();
        }

        public void Update(Feedback entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var feedback = db.Feedbacks.Find(id);
            if (feedback != null)
            {
                db.Feedbacks.Remove(feedback);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        int IRepo<Feedback, string, int>.Create(Feedback obj)
        {
            throw new NotImplementedException();
        }

        public List<Feedback> Read()
        {
            throw new NotImplementedException();
        }

        public Feedback Read(string id)
        {
            throw new NotImplementedException();
        }

        int IRepo<Feedback, string, int>.Update(Feedback obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public object Read(int id)
        {
            throw new NotImplementedException();
        }

        public object ReadWhere(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
