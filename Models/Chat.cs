using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GHC2.Models
{
    public class Chat
    {
        public Chat()
        {
            Messages = new List<Message>();
            Uesrs = new List<ChatUser>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ChatType Type { get; set; }

        public ICollection<Message> Messages { get; set; }
        public ICollection<ChatUser> Uesrs { get; set; }
    }
}
