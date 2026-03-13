namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TourAndTravel.DAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TourAndTravel.DAL.Models.TourAndTravelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TourAndTravel.DAL.Models.TourAndTravelContext context)
        {
            // Sample Muslim names for seeding
            string[] muslimNames = { "Ayesha", "Fatima", "Mohammed", "Ahmed", "Ali", "Hassan", "Hussein", "Omar", "Zainab", "Yusuf" };

            // Seed Customers with Bangladeshi phone numbers and Gmail addresses
            string[] phonePrefixes = { "017", "018", "016", "013" };
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                string phonePrefix = phonePrefixes[rand.Next(phonePrefixes.Length)];
                string phoneNumber = phonePrefix + rand.Next(10000000, 99999999).ToString(); // Random 8 digits
                string name = muslimNames[rand.Next(muslimNames.Length)]; // Random name from the list

                context.Customers.AddOrUpdate(x => x.Email, new Customer
                {
                    CustomerId = i,
                    Name = name,
                    Email = $"{name.ToLower()}{i}@gmail.com",
                    Password = $"password{i}",
                    Address = $"1219 Main St, City{i}, Country",
                    PhoneNumber = $"+88{phoneNumber}"
                });
            }

            // Seed TourPackages
            for (int i = 1; i <= 10; i++)
            {
                context.TourPackages.AddOrUpdate(x => x.Name, new TourPackage
                {
                    TourPackageId = i,
                    Name = $"Tour Package {i}",
                    Description = $"Description for Tour Package {i}.",
                    Price = 100 * i,
                    Destination = $"Destination {i}"
                });
            }

            // Seed Bookings
            for (int i = 1; i <= 10; i++)
            {
                context.Bookings.AddOrUpdate(x => x.BookingDate, new Booking
                {
                    BookingId = i,
                    CustomerId = i, // Make sure these IDs exist in the Customers table
                    TourPackageId = i, // Make sure these IDs exist in the TourPackages table
                    BookingDate = DateTime.Now.AddDays(-i),
                    NumberOfPeople = 1 + i, // Just as an example
                    SpecialRequests = i % 2 == 0 ? "Window seat" : "Aisle seat"
                });
            }

            // Seed Payments
            for (int i = 1; i <= 10; i++)
            {
                context.Payments.AddOrUpdate(x => x.PaymentDate, new Payment
                {
                    PaymentId = i,
                    BookingId = i, // Make sure these IDs exist in the Bookings table
                    Amount = 200 * i,
                    PaymentDate = DateTime.Now.AddDays(-i),
                    PaymentMethod = "Cash" // Simplified for the example
                });
            }

            // Seed Feedbacks
            for (int i = 1; i <= 10; i++)
            {
                context.Feedbacks.AddOrUpdate(x => x.Date, new Feedback
                {
                    FeedbackId = i,
                    CustomerId = i, // Make sure these IDs exist in the Customers table
                    Content = $"This is feedback content for feedback {i}.",
                    Date = DateTime.Now.AddDays(-i),
                    Rating = rand.Next(1, 6) // Random rating between 1 and 5
                });
            }

            // Save the changes to the database
            context.SaveChanges();
        }
    }
}
