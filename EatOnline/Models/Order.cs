using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string State { get; set; }
        public DateTime OderDate { get; set; }
        public ContactData ContactDataID { get; set; }

        public ContactData ContactData
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