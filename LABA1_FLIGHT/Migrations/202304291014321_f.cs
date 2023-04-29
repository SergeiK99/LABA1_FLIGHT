namespace LABA1_FLIGHT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "FlightNumber", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Flights", "FlightNumber");
        }
    }
}
