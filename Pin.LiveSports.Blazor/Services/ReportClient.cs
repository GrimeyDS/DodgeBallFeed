using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using Pin.LiveSports.Blazor.Hubs;
using Pin.LiveSports.Core.Entities.Reports;

namespace Pin.LiveSports.Blazor.Services
{
    public class ReportClient
    {
        protected HubConnection connection = null;

        public ReportClient()
        {
            connection = new HubConnectionBuilder().WithUrl("https://localhost:7005/reportHub").Build();
        }

        public void Configure(Action<string> callBack)
        {
            connection.On("reportAdded", callBack);
        }


        public async Task StartAsync()
        {
            await connection.StartAsync();
        }

        public async Task AddItemAsync(GeneralReport item)
        {
            string json = JsonConvert.SerializeObject(item);
            await connection.SendAsync(nameof(ReportHub.AddReport), json);
        }
    }
}
