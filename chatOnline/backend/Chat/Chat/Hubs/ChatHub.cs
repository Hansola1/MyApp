using Microsoft.AspNetCore.SignalR;
using Chat.Models;

public interface IChatClient 
{
    public Task ReceiveMessage(string userName, string message);
}

namespace Chat.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public  async Task JoinChat(UserConnection connection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, connection.ChatRoom);
            await Clients.Group(connection.ChatRoom).ReceiveMessage("Admin", $"{connection.UserName} добавился в чат");
        }
    }
}
