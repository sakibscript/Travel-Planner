namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitAdditionalField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Budgets", "EstimatedCost", c => c.Double(nullable: false));
            AddColumn("dbo.Budgets", "ActualCost", c => c.Double());
            AddColumn("dbo.Trips", "TravelMode", c => c.String());
            AddColumn("dbo.Trips", "NoOfTravellers", c => c.Int(nullable: false));
            AddColumn("dbo.Trips", "Rating", c => c.Double());
            AddColumn("dbo.Packings", "Priority", c => c.String());
            DropColumn("dbo.Budgets", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Budgets", "Cost", c => c.Double(nullable: false));
            DropColumn("dbo.Packings", "Priority");
            DropColumn("dbo.Trips", "Rating");
            DropColumn("dbo.Trips", "NoOfTravellers");
            DropColumn("dbo.Trips", "TravelMode");
            DropColumn("dbo.Budgets", "ActualCost");
            DropColumn("dbo.Budgets", "EstimatedCost");
        }
    }
}
