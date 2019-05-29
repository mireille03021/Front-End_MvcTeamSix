namespace ANVI_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.Decimal(storeType: "money"));
        }
    }
}
