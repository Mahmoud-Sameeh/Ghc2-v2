using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class AppUser :IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        public int I { get; set; }
        public string UserName { get; set; }
        public int Text { get; set; }
        public int When { get; set; }
        public int UserID { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
