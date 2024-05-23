namespace WebBlazor.Infrastructure.Interfaces
{
    public interface IChatService
    {
        Task SendMessageAsync(string senderName, string message);
    }
}
