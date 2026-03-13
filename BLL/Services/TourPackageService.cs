using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace BLL.Services
{
    public class TourPackageService
    {
        public static List<TourPackageDTO> GetAllTourPackages()
        {
            var data = DataAccessFactory.TourPackageData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TourPackage, TourPackageDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TourPackageDTO>>(data);
            return mapped;
        }

        
         

    }
}
