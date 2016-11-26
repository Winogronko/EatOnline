namespace EatOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Baskets", "User_UserID", c => c.Int());
            AddColumn("dbo.Dishes", "Category_CategoryID", c => c.Int());
            AddColumn("dbo.Dishes", "Ingredient_IngredientID", c => c.Int());
            AddColumn("dbo.Ingredients", "Category_CategoryID", c => c.Int());
            AddColumn("dbo.OrderDishes", "Basket_BasketID", c => c.Int());
            AddColumn("dbo.OrderDishes", "Dish_DishID", c => c.Int());
            AddColumn("dbo.OrderDishes", "Order_OrderID", c => c.Int());
            AddColumn("dbo.Orders", "ContactData_ContactDataID", c => c.Int());
            CreateIndex("dbo.Baskets", "User_UserID");
            CreateIndex("dbo.Dishes", "Category_CategoryID");
            CreateIndex("dbo.Dishes", "Ingredient_IngredientID");
            CreateIndex("dbo.Ingredients", "Category_CategoryID");
            CreateIndex("dbo.OrderDishes", "Basket_BasketID");
            CreateIndex("dbo.OrderDishes", "Dish_DishID");
            CreateIndex("dbo.OrderDishes", "Order_OrderID");
            CreateIndex("dbo.Orders", "ContactData_ContactDataID");
            AddForeignKey("dbo.Baskets", "User_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.Dishes", "Category_CategoryID", "dbo.Categories", "CategoryID");
            AddForeignKey("dbo.Ingredients", "Category_CategoryID", "dbo.Categories", "CategoryID");
            AddForeignKey("dbo.Dishes", "Ingredient_IngredientID", "dbo.Ingredients", "IngredientID");
            AddForeignKey("dbo.OrderDishes", "Basket_BasketID", "dbo.Baskets", "BasketID");
            AddForeignKey("dbo.OrderDishes", "Dish_DishID", "dbo.Dishes", "DishID");
            AddForeignKey("dbo.Orders", "ContactData_ContactDataID", "dbo.ContactDatas", "ContactDataID");
            AddForeignKey("dbo.OrderDishes", "Order_OrderID", "dbo.Orders", "OrderID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDishes", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ContactData_ContactDataID", "dbo.ContactDatas");
            DropForeignKey("dbo.OrderDishes", "Dish_DishID", "dbo.Dishes");
            DropForeignKey("dbo.OrderDishes", "Basket_BasketID", "dbo.Baskets");
            DropForeignKey("dbo.Dishes", "Ingredient_IngredientID", "dbo.Ingredients");
            DropForeignKey("dbo.Ingredients", "Category_CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Dishes", "Category_CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Baskets", "User_UserID", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "ContactData_ContactDataID" });
            DropIndex("dbo.OrderDishes", new[] { "Order_OrderID" });
            DropIndex("dbo.OrderDishes", new[] { "Dish_DishID" });
            DropIndex("dbo.OrderDishes", new[] { "Basket_BasketID" });
            DropIndex("dbo.Ingredients", new[] { "Category_CategoryID" });
            DropIndex("dbo.Dishes", new[] { "Ingredient_IngredientID" });
            DropIndex("dbo.Dishes", new[] { "Category_CategoryID" });
            DropIndex("dbo.Baskets", new[] { "User_UserID" });
            DropColumn("dbo.Orders", "ContactData_ContactDataID");
            DropColumn("dbo.OrderDishes", "Order_OrderID");
            DropColumn("dbo.OrderDishes", "Dish_DishID");
            DropColumn("dbo.OrderDishes", "Basket_BasketID");
            DropColumn("dbo.Ingredients", "Category_CategoryID");
            DropColumn("dbo.Dishes", "Ingredient_IngredientID");
            DropColumn("dbo.Dishes", "Category_CategoryID");
            DropColumn("dbo.Baskets", "User_UserID");
        }
    }
}
