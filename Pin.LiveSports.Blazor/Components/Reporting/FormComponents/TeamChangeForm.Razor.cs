using Microsoft.AspNetCore.Components;
using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Entities.Reports;

namespace Pin.LiveSports.Blazor.Components.Reporting.FormComponents
{
    public partial class TeamChangeForm
    {
        [Parameter]
        public TeamChangeReport ReportItem { get; set; }

        private Player[] teamPlayers;

        private void SetTeam(Guid id)
        {
            ReportItem.Team = Teams.FirstOrDefault(t => t.Id == id);
            if (ReportItem.Team is not null)
                teamPlayers = ReportItem.Team.Players.ToArray();
        }

        private void SetPlayer(Guid id)
        {
            ReportItem.Player = teamPlayers.FirstOrDefault(p => p.Id == id);
        }

        private void SetGamePlayer()
        {
            ReportItem.IsOut = ReportItem.Player.IsOut;
            OnSave.InvokeAsync(ReportItem);
        }
    }
}
