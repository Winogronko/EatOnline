using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class ContactData
    {
        public int ContactDataID { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int FlatNumber { get; set; }
        [DataType(DataType.PhoneNumber)] public int PhoneNumber { get; set; }
    }
}