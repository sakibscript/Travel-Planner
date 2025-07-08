namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitTravelPlannerDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        BudgetID = c.Int(nullable: false, identity: true),
                        TripID = c.Int(nullable: false),
                        Category = c.String(),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BudgetID)
                .ForeignKey("dbo.Trips", t => t.TripID, cascadeDelete: true)
                .Index(t => t.TripID);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        TripName = c.String(),
                        Destination = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ItinerarySummary = c.String(),
                    })
                .PrimaryKey(t => t.TripID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Packings",
                c => new
                    {
                        PackingItemID = c.Int(nullable: false, identity: true),
                        TripID = c.Int(nullable: false),
                        ItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        IsPacked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PackingItemID)
                .ForeignKey("dbo.Trips", t => t.TripID, cascadeDelete: true)
                .Index(t => t.TripID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Budgets", "TripID", "dbo.Trips");
            DropForeignKey("dbo.Trips", "UserID", "dbo.Users");
            DropForeignKey("dbo.Packings", "TripID", "dbo.Trips");
            DropIndex("dbo.Packings", new[] { "TripID" });
            DropIndex("dbo.Trips", new[] { "UserID" });
            DropIndex("dbo.Budgets", new[] { "TripID" });
            DropTable("dbo.Users");
            DropTable("dbo.Packings");
            DropTable("dbo.Trips");
            DropTable("dbo.Budgets");
        }
    }
}
