using Models;

namespace Infrastructure.Interfaces
{
    public interface IChatService
    {
        Task ConnectAsync(string url);
        Task SendMessageAsync(string senderName, string message);
        Task OnReceiveMessage(Action<ChatMessage> onMessageReceived);
    }
}
