using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class EatOnlineContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EatOnlineContext() : base("name=EatOnlineContext")
        {
        }

        public System.Data.Entity.DbSet<EatOnline.Models.Basket> Baskets { get; set; }

        public System.Data.Entity.DbSet<EatOnline.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<EatOnline.Models.Dish> Dishes { get; set; }

        public System.Data.Entity.DbSet<EatOnline.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<EatOnline.Models.ContactData> ContactDatas { get; set; }

        public System.Data.Entity.DbSet<EatOnline.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<EatOnline.Models.Ingredient> Ingredients { get; set; }

        public System.Data.Entity.DbSet<EatOnline.Models.OrderDish> OrderDishes { get; set; }
    
    }
}
