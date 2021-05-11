namespace GHC2.Models
{
    public class ChatUser
    {
        public string UserId { set; get; }
        public Uesr User { set; get; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public UserRole userRole { get; set; }
    }
}
