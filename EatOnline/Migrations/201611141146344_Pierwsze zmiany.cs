namespace EatOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pierwszezmiany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Baskets", "UserID_UserID", c => c.Int());
            AddColumn("dbo.OrderDishes", "BasketID_BasketID", c => c.Int());
            AddColumn("dbo.OrderDishes", "DishID_DishID", c => c.Int());
            AddColumn("dbo.OrderDishes", "OrderID_OrderID", c => c.Int());
            AddColumn("dbo.Orders", "ContactDataID_ContactDataID", c => c.Int());
            CreateIndex("dbo.Baskets", "UserID_UserID");
            CreateIndex("dbo.OrderDishes", "BasketID_BasketID");
            CreateIndex("dbo.OrderDishes", "DishID_DishID");
            CreateIndex("dbo.OrderDishes", "OrderID_OrderID");
            CreateIndex("dbo.Orders", "ContactDataID_ContactDataID");
            AddForeignKey("dbo.Baskets", "UserID_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.OrderDishes", "BasketID_BasketID", "dbo.Baskets", "BasketID");
            AddForeignKey("dbo.OrderDishes", "DishID_DishID", "dbo.Dishes", "DishID");
            AddForeignKey("dbo.Orders", "ContactDataID_ContactDataID", "dbo.ContactDatas", "ContactDataID");
            AddForeignKey("dbo.OrderDishes", "OrderID_OrderID", "dbo.Orders", "OrderID");
            DropColumn("dbo.Baskets", "UserID");
            DropColumn("dbo.OrderDishes", "DishID");
            DropColumn("dbo.OrderDishes", "BasketID");
            DropColumn("dbo.OrderDishes", "OrderID");
            DropColumn("dbo.Orders", "ContactDataID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ContactDataID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDishes", "OrderID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDishes", "BasketID", c => c.Int(nullable: false));
            AddColumn("dbo.OrderDishes", "DishID", c => c.Int(nullable: false));
            AddColumn("dbo.Baskets", "UserID", c => c.Int(nullable: false));
            DropForeignKey("dbo.OrderDishes", "OrderID_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ContactDataID_ContactDataID", "dbo.ContactDatas");
            DropForeignKey("dbo.OrderDishes", "DishID_DishID", "dbo.Dishes");
            DropForeignKey("dbo.OrderDishes", "BasketID_BasketID", "dbo.Baskets");
            DropForeignKey("dbo.Baskets", "UserID_UserID", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "ContactDataID_ContactDataID" });
            DropIndex("dbo.OrderDishes", new[] { "OrderID_OrderID" });
            DropIndex("dbo.OrderDishes", new[] { "DishID_DishID" });
            DropIndex("dbo.OrderDishes", new[] { "BasketID_BasketID" });
            DropIndex("dbo.Baskets", new[] { "UserID_UserID" });
            DropColumn("dbo.Orders", "ContactDataID_ContactDataID");
            DropColumn("dbo.OrderDishes", "OrderID_OrderID");
            DropColumn("dbo.OrderDishes", "DishID_DishID");
            DropColumn("dbo.OrderDishes", "BasketID_BasketID");
            DropColumn("dbo.Baskets", "UserID_UserID");
        }
    }
}
