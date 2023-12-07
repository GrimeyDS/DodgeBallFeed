using Microsoft.AspNetCore.SignalR;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class ReportHub
    {
        public async Task Send(string name, string message)
        {
            await Clients.All.SendAsync("report", name, message);
        }
    }
}
