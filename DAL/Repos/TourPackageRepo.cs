using DAL.Interfaces;
using DAL.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TourAndTravel.DAL.Models;

namespace DAL.Repos
{
    internal class TourPackageRepo : Repo, IRepo<TourPackage, string, int>
    {
        public int Create(TourPackage obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<TourPackage> Read()
        {
            return db.TourPackages.ToList();
        }

        public TourPackage Read(string id)
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

        public int Update(TourPackage obj)
        {
            throw new NotImplementedException();
        }
    }


}
