namespace EatOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        BasketID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BasketID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Dish_DishID = c.Int(),
                        Ingredient_IngredientID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryID)
                .ForeignKey("dbo.Dishes", t => t.Dish_DishID)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_IngredientID)
                .Index(t => t.Dish_DishID)
                .Index(t => t.Ingredient_IngredientID);
            
            CreateTable(
                "dbo.ContactDatas",
                c => new
                    {
                        ContactDataID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        FlatNumber = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactDataID);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        DishID = c.Int(nullable: false, identity: true),
                        DishName = c.String(),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Calorific = c.Int(nullable: false),
                        PreparationTime = c.Int(nullable: false),
                        Availability = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DishID);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientID = c.Int(nullable: false, identity: true),
                        IngredientName = c.String(),
                        Dish_DishID = c.Int(),
                    })
                .PrimaryKey(t => t.IngredientID)
                .ForeignKey("dbo.Dishes", t => t.Dish_DishID)
                .Index(t => t.Dish_DishID);
            
            CreateTable(
                "dbo.OrderDishes",
                c => new
                    {
                        OrderDishID = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        DishID = c.Int(nullable: false),
                        BasketID = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDishID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        State = c.String(),
                        OderDate = c.DateTime(nullable: false),
                        ContactDataID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserRole = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        LastLogin = c.DateTime(nullable: false),
                        DateJoined = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "Dish_DishID", "dbo.Dishes");
            DropForeignKey("dbo.Categories", "Ingredient_IngredientID", "dbo.Ingredients");
            DropForeignKey("dbo.Categories", "Dish_DishID", "dbo.Dishes");
            DropIndex("dbo.Ingredients", new[] { "Dish_DishID" });
            DropIndex("dbo.Categories", new[] { "Ingredient_IngredientID" });
            DropIndex("dbo.Categories", new[] { "Dish_DishID" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDishes");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Dishes");
            DropTable("dbo.ContactDatas");
            DropTable("dbo.Categories");
            DropTable("dbo.Baskets");
        }
    }
}
