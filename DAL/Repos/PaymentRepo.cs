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
    internal class PaymentRepo : IRepo<Payment,string, int>
    {
        private readonly TourAndTravelContext db;

        public PaymentRepo(TourAndTravelContext context)
        {
            db = context;
        }

        public PaymentRepo()
        {
        }

        public Payment Create(Payment entity)
        {
            db.Payments.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public IEnumerable<Payment> ReadAll()
        {
            return db.Payments.ToList();
        }

        public Payment ReadById(int id)
        {
            return db.Payments.Find(id);
        }

        public IEnumerable<Payment> ReadWhere(Expression<Func<Payment, bool>> predicate)
        {
            return db.Payments.Where(predicate).ToList();
        }

        public void Update(Payment entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var payment = db.Payments.Find(id);
            if (payment != null)
            {
                db.Payments.Remove(payment);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        int IRepo<Payment, string, int>.Create(Payment obj)
        {
            throw new NotImplementedException();
        }

        public List<Payment> Read()
        {
            throw new NotImplementedException();
        }

        public Payment Read(string id)
        {
            throw new NotImplementedException();
        }

        int IRepo<Payment, string, int>.Update(Payment obj)
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
