using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TourAndTravel.DAL.Models;
using Microsoft.Win32;
using DAL.Repos;

namespace DAL.Repos
{
    internal class CustomerRepo :Repo, IRepo<Customer, string, int>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Customers.FirstOrDefault(u => u.Name.Equals(username) && u.Password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public int Create(Customer obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Read()
        {
            return db.Customers.ToList();
        }

        public Customer Read(string id)
        {
            return db.Customers.Find(id);
        }

        public object Read(int id)
        {
            throw new NotImplementedException();
        }

        public object ReadWhere(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public int Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IRepo<T1, T2, T3, T4>
    {
    }
}
