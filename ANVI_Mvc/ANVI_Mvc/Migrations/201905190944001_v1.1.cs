namespace ANVI_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductDestails", newName: "ProductDetails");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ProductDetails", newName: "ProductDestails");
        }
    }
}
