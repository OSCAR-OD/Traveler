namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feedbacks", "TourPackage_TourPackageId", c => c.Int());
            CreateIndex("dbo.Feedbacks", "TourPackage_TourPackageId");
            AddForeignKey("dbo.Feedbacks", "TourPackage_TourPackageId", "dbo.TourPackages", "TourPackageId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "TourPackage_TourPackageId", "dbo.TourPackages");
            DropIndex("dbo.Feedbacks", new[] { "TourPackage_TourPackageId" });
            DropColumn("dbo.Feedbacks", "TourPackage_TourPackageId");
        }
    }
}
