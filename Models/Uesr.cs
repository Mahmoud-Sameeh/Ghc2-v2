using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace GHC2.Models
{
    public class Uesr : IdentityUser
    {
        public ICollection<ChatUser> Chats { set; get; }
    }
}
