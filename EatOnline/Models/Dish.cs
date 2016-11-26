using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class Dish
    {
        public int DishID { get; set; }
        public string DishName { get; set; }
        public virtual List<Ingredient> IngredientID { get; set; }
        [DataType(DataType.MultilineText)] public string Description { get; set; }
        [DataType(DataType.Currency)] public int Price { get; set; }
        public int Weight { get; set; }
        public int Calorific { get; set; }
        public int PreparationTime { get; set; }
        public int Availability { get; set; }
        public virtual List<Category> CategoryID { get; set; }

        public Ingredient Ingredient
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

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