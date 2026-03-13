using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, string, int> CustomerData()
        {
            return new CustomerRepo();
        }

        public static IRepo<TourPackage, string, int> TourPackageData()
        {
            return new TourPackageRepo();
        }

        public static IRepo<Booking, string, int> BookingData()
        {
            return new BookingRepo();
        }

        public static IRepo<Payment, string, int> PaymentData()
        {
            return new PaymentRepo();
        }

        public static IRepo<Feedback, string, int> FeedbackData()
        {
            return new FeedbackRepo();
        }

        public static IAuth<bool> AuthData()
        {
            return new CustomerRepo();
        }


    }
}
