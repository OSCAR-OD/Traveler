using DAL.Models;
using System.Data.Entity;
using TourAndTravel.DAL.Models;

namespace TourAndTravel.DAL.Models
{
    public class TourAndTravelContext : DbContext
    {
        

       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
