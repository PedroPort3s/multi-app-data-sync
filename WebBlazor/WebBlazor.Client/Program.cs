using Infrastructure.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace WebBlazor.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddTransient<IChatService, ChatService>();

            await builder.Build().RunAsync();
        }
    }
}
