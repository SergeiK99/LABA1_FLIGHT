namespace LABA1_FLIGHT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SeatCategories", "Category", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SeatCategories", "Category", c => c.Boolean(nullable: false));
        }
    }
}
