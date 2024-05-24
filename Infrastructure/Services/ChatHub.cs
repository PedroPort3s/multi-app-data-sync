using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Models;
using System.Net.Sockets;

namespace Infrastructure.Services
{
    public class ChatHub : Hub
    {
        private readonly ILogger<ChatHub> _logger;

        public ChatHub(ILogger<ChatHub> logger)
        {
            _logger = logger;
        }

        public async Task Connect()
        {
            await Clients.Caller.SendAsync("Connected", false);
        }

        public async Task SendMessage(ChatMessage message)
        {
            try
            {
                await Clients.All.SendAsync("ReceiveMessage", message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error sending message: {ex.Message}");
            }
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            if (exception != null)
            {
                _logger.LogError($"Client disconnected due to error: {exception.Message}");
            }
            else
            {
                _logger.LogInformation("Client disconnected successfully");
            }

            await base.OnDisconnectedAsync(exception);
        }
    }
}
