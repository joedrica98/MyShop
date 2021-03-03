namespace MyShop.DataAcces.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBasket1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BasketItems", name: "Basket_Id", newName: "BasketId");
            RenameIndex(table: "dbo.BasketItems", name: "IX_Basket_Id", newName: "IX_BasketId");
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.BasketItems", "BaskId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BasketItems", "BaskId", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.String());
            RenameIndex(table: "dbo.BasketItems", name: "IX_BasketId", newName: "IX_Basket_Id");
            RenameColumn(table: "dbo.BasketItems", name: "BasketId", newName: "Basket_Id");
        }
    }
}
