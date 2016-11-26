using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EatOnline.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserRole { get; set; }
        [DataType(DataType.EmailAddress)] public string Email { get; set; }
        [DataType(DataType.Password)] public string Password { get; set; }
        [DataType(DataType.Date)][DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastLogin { get; set; }
        [DataType(DataType.Date)] public DateTime DateJoined { get; set; }
    }
}