using Microsoft.AspNetCore.SignalR;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class ReportHub : Hub
    {
        public async Task AddReport(string game)
        {
            await Clients.Others.SendAsync("reportAdded", game);
        }
    }
}
