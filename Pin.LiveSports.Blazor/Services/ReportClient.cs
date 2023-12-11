using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using Pin.LiveSports.Blazor.Hubs;
using Pin.LiveSports.Core.Entities.Games;

namespace Pin.LiveSports.Blazor.Services
{
    public class ReportClient
    {
        protected HubConnection connection = null;

        public ReportClient()
        {
            connection = new HubConnectionBuilder().WithUrl("https://localhost:7005/reportHub").Build();
        }

        public void Configure(Action<Game> callBack)
        {
            connection.On("reportAdded", callBack);
        }


        public async Task StartAsync()
        {
            await connection.StartAsync();
        }

        public async Task AddItemAsync(Game game)
        {
            await connection.SendAsync(nameof(ReportHub.AddReport), game);
        }
    }
}
