using Microsoft.AspNetCore.SignalR;
using Pin.LiveSports.Core.Entities.Reports;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class ReportHub : Hub
    {
        public async Task AddReport(string report)
        {
            await Clients.Others.SendAsync("reportAdded", report);
        }
    }
}
