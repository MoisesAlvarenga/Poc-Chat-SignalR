using Microsoft.AspNetCore.SignalR;

namespace ChatServer.ChatHubs;

    public class ChatHub : Hub
    {
       public async Task NewMessage(string username, string message) =>
        await Clients.All.SendAsync("messageReceived", username, message);
    }
