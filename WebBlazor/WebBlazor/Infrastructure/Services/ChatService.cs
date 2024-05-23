using Microsoft.AspNetCore.SignalR;
using Models;
using WebBlazor.Infrastructure.Interfaces;
using WebServer;

namespace WebBlazor.Infrastructure.Services
{
    public class ChatService : IChatService
    {
        private readonly IHubContext<ChatHub> HubContext;

        public ChatService(IHubContext<ChatHub> hubContext)
        {
            HubContext = hubContext;
        }

        public async Task SendMessageAsync(string senderName, string message)
        {
            ChatMessage chatMessage = new ChatMessage
            {
                Content = message,
                Sender = senderName,
                Timestamp = DateTime.Now
            };

            await HubContext.Clients.All.SendAsync("ReceiveMessage", chatMessage);
        }
    }
}
