namespace LABA1_FLIGHT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 50),
                        Route_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.Route_Id)
                .Index(t => t.Route_Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RouteNumber = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchasedSeats = c.Int(nullable: false),
                        ReservedSeats = c.Int(nullable: false),
                        DepatureDate = c.DateTime(nullable: false),
                        IsInnerFlight = c.Boolean(nullable: false),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.SeatCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeatCategoryId = c.Int(nullable: false),
                        FlightId = c.Int(nullable: false),
                        IsReserved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .ForeignKey("dbo.SeatCategories", t => t.SeatCategoryId, cascadeDelete: true)
                .Index(t => t.SeatCategoryId)
                .Index(t => t.FlightId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "SeatCategoryId", "dbo.SeatCategories");
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Flights", "RouteId", "dbo.Routes");
            DropForeignKey("dbo.Destinations", "Route_Id", "dbo.Routes");
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            DropIndex("dbo.Tickets", new[] { "SeatCategoryId" });
            DropIndex("dbo.Flights", new[] { "RouteId" });
            DropIndex("dbo.Destinations", new[] { "Route_Id" });
            DropTable("dbo.Tickets");
            DropTable("dbo.SeatCategories");
            DropTable("dbo.Flights");
            DropTable("dbo.Routes");
            DropTable("dbo.Destinations");
        }
    }
}
