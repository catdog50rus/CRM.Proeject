namespace CRM.Proeject.BL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCheck : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Checks", new[] { "CustomerID" });
            DropIndex("dbo.Checks", new[] { "SellerID" });
            DropIndex("dbo.Sells", new[] { "CheckID" });
            AddColumn("dbo.Checks", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Checks", "CustomerId");
            CreateIndex("dbo.Checks", "SellerId");
            CreateIndex("dbo.Sells", "CheckId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Sells", new[] { "CheckId" });
            DropIndex("dbo.Checks", new[] { "SellerId" });
            DropIndex("dbo.Checks", new[] { "CustomerId" });
            DropColumn("dbo.Checks", "Price");
            CreateIndex("dbo.Sells", "CheckID");
            CreateIndex("dbo.Checks", "SellerID");
            CreateIndex("dbo.Checks", "CustomerID");
        }
    }
}
