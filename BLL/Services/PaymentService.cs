using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class PaymentService
    {
              

        public static PaymentDTO CreatePayment(PaymentDTO paymentDTO)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentDTO, Payment>();
            });
            var mapper = new Mapper(cfg);
            var payment = mapper.Map<Payment>(paymentDTO);

            var createdPayment = DataAccessFactory.PaymentData().Create(payment);
            var createdPaymentDTO = mapper.Map<PaymentDTO>(createdPayment);

            return createdPaymentDTO;
        }

        

        
    }
}
