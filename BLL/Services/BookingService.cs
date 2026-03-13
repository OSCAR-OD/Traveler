using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class BookingService
    {
         

        public static BookingDTO CreateBooking(BookingDTO bookingDTO)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BookingDTO, Booking>();
            });
            var mapper = new Mapper(cfg);
            var booking = mapper.Map<Booking>(bookingDTO);

            var createdBooking = DataAccessFactory.BookingData().Create(booking);
            var createdBookingDTO = mapper.Map<BookingDTO>(createdBooking);

            return createdBookingDTO;
        }

        
    }
}
