using Infrastructure.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using Models;

namespace Infrastructure.Services
{
    public class ChatService : IChatService
    {
        private HubConnection connection;

        public ChatService()
        {

        }

        public async Task ConnectAsync(string url)
        {
            connection = new HubConnectionBuilder()
                .WithUrl(url)
                .Build();

            await connection.StartAsync();
        }

        public async Task SendMessageAsync(string senderName, string message)
        {
            ChatMessage chatMessage = new ChatMessage
            {
                Content = message,
                Sender = senderName,
                Timestamp = DateTime.Now
            };

            await connection.SendAsync("SendMessage", chatMessage);
        }

        public async Task OnReceiveMessage(Action<ChatMessage> onMessageReceived)
        {
            connection.On<ChatMessage>("ReceiveMessage", (message) => onMessageReceived(message));

            if (connection.State != HubConnectionState.Connected)
            {
                await connection.StartAsync();
            }
        }
    }
}
