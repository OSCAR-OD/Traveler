namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TourPackageId = c.Int(nullable: false),
                        BookingDate = c.DateTime(nullable: false),
                        NumberOfPeople = c.Int(nullable: false),
                        SpecialRequests = c.String(),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.TourPackages", t => t.TourPackageId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.TourPackageId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Content = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeedbackId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        BookingId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        PaymentMethod = c.String(),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .Index(t => t.BookingId);
            
            CreateTable(
                "dbo.TourPackages",
                c => new
                    {
                        TourPackageId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Destination = c.String(),
                    })
                .PrimaryKey(t => t.TourPackageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "TourPackageId", "dbo.TourPackages");
            DropForeignKey("dbo.Payments", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.Feedbacks", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Payments", new[] { "BookingId" });
            DropIndex("dbo.Feedbacks", new[] { "CustomerId" });
            DropIndex("dbo.Bookings", new[] { "TourPackageId" });
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            DropTable("dbo.TourPackages");
            DropTable("dbo.Payments");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
