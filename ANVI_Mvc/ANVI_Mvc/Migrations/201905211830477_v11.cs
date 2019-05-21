namespace ANVI_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
