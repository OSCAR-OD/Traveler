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
    internal class BookingRepo : IRepo<Booking, string, int>
    {
        private readonly TourAndTravelContext db;

        public BookingRepo(TourAndTravelContext context)
        {
            db = context;
        }

        public BookingRepo()
        {
        }

        public Booking Create(Booking entity)
        {
            db.Bookings.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public IEnumerable<Booking> ReadAll()
        {
            return db.Bookings.ToList();
        }

        public Booking ReadById(int id)
        {
            return db.Bookings.Find(id);
        }

        public IEnumerable<Booking> ReadWhere(Expression<Func<Booking, bool>> predicate)
        {
            return db.Bookings.Where(predicate).ToList();
        }

        public void Update(Booking entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var booking = db.Bookings.Find(id);
            if (booking != null)
            {
                db.Bookings.Remove(booking);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        int IRepo<Booking, string, int>.Create(Booking obj)
        {
            throw new NotImplementedException();
        }

        List<Booking> IRepo<Booking, string, int>.Read()
        {
            throw new NotImplementedException();
        }

        Booking IRepo<Booking, string, int>.Read(string id)
        {
            throw new NotImplementedException();
        }

        int IRepo<Booking, string, int>.Update(Booking obj)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Booking, string, int>.Delete(string id)
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
