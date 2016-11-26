using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class Basket
    {
        public int BasketID { get; set; }
        public User UserID { get; set; }

        public User User
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