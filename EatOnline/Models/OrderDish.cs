using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class OrderDish
    {
        public int OrderDishID { get; set; }
        public int Count { get; set; }
        public Dish DishID { get; set; }
        public Basket BasketID { get; set; }
        public Order OrderID { get; set; }

        public Dish Dish
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Basket Basket
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Order Order
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