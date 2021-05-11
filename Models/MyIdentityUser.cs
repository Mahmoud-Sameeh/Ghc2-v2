using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class MyIdentityUser:IdentityUser
    {
        public string Name { get; set; }
        public DateTime dateTime { get; set; }
        //public Address { get; set; }

    }
    public class MyIdentityRole : IdentityRole
    {
    }
}
