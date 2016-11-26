using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public virtual List<Category> CategoryID { get; set; }

        public Category Category
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}