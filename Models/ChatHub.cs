using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class ChatHub : Hub
    {
        public string GetConectionId() =>
            Context.ConnectionId;

        public async Task SendMessage(string fromUser, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", fromUser, message);
        }
    }
}
