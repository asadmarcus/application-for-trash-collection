namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customertableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        AccountName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        PhoneNumber = c.String(),
                        RegularPickupActive = c.Boolean(nullable: false),
                        RegularPickupDayOfWeek = c.Int(nullable: false),
                        RegularPickupStartDate = c.DateTime(nullable: false),
                        RegularPickupEndDate = c.DateTime(nullable: false),
                        RegularPickupPrice = c.Double(nullable: false),
                        SpecialPickupActive = c.Boolean(nullable: false),
                        SpecialPickupDayOfWeek = c.Int(nullable: false),
                        SpecialPickupStartDate = c.DateTime(nullable: false),
                        SpecialPickupEndDate = c.DateTime(nullable: false),
                        SpecialPickupPrice = c.Double(nullable: false),
                        VacationActivePickupPaused = c.Boolean(nullable: false),
                        VacationStartDate = c.DateTime(nullable: false),
                        VacationEndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
