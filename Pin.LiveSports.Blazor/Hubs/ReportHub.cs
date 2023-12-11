using Microsoft.AspNetCore.SignalR;
using Pin.LiveSports.Core.Entities.Games;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class ReportHub : Hub
    {
        public async Task AddReport(Game game)
        {
            await Clients.Others.SendAsync("reportAdded", game);
        }
    }
}
