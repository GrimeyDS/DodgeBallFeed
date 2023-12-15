using Microsoft.AspNetCore.Components;
using Pin.LiveSports.Blazor.Components.SubComponents;
using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Entities.Reports;

namespace Pin.LiveSports.Blazor.Components.Reporting
{
    public partial class Reportage
    {
        [Parameter]
        public EventCallback<Game> OnSave { get; set; }

        [Parameter]
        public Game Game { get; set; }

        [Parameter]
        public Team[] Teams { get; set; }

        [Parameter]
        public List<Game> Games { get; set; }

        private readonly string[] reportTypes = ["Game", "Feed"];
        private readonly string[] subReportTypes = ["General", "Foul", "Team Change", "Sudden Death", "Score", "Win"];

        private string selectedReportType;
        private string selectedSubReportType;
        private Guid selectedGameId;

        private Team[] gameTeams;

        private GeneralReport reportItem;

        private Select _selectReport;
        private Select _selectSubReport;


        private void ChangeReportType(string selectedItem)
        {
            selectedReportType = selectedItem;
            if (selectedReportType == "Game")
                Game = new Game();
        }

        private void ChangeSubReportType(string selectedItem)
        {
            selectedSubReportType = selectedItem;
        }

        private void ChangeCurrentGame(ChangeEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Value.ToString()))
            {
                selectedGameId = Guid.Parse(e.Value.ToString());
                Game = Games.FirstOrDefault(g => g.Id == selectedGameId);
                gameTeams = [Game.AwayTeam, Game.HomeTeam];
            }
        }

        private void SaveReportItem(GeneralReport reportItem)
        {
            RefreshSelects();
            Game.GameTime = reportItem.Time;

            var reportTypeName = reportItem.GetType().Name;
            switch (reportTypeName)
            {
                case nameof(GeneralReport):
                    Game.GeneralReports.Add(reportItem);
                    break;
                case nameof(FoulReport):
                    Game.FoulReports.Add((FoulReport)reportItem);
                    break;
                case nameof(TeamChangeReport):
                    Game.TeamChangeReports.Add((TeamChangeReport)reportItem);
                    CheckPlayerStatus();
                    break;
                case nameof(SuddenDeathReport):
                    Game.SuddenDeathReports.Add((SuddenDeathReport)reportItem);
                    break;
                case nameof(ScoreReport):
                    //SetGameScore(((ScoreReport)reportItem).ScoredTeam);
                    Game.ScoreReports.Add((ScoreReport)reportItem);
                    break;
                case nameof(WinReport):
                    Game.WinReports.Add((WinReport)reportItem);
                    break;
                default:
                    break;
            }

            OnSave.InvokeAsync(Game);
        }

        private void SaveGame(Game game)
        {
            RefreshSelects();
            CreateGeneralReport("Game Start", "Game has started. Reports will follow");
            OnSave.InvokeAsync(game);
        }

        private void RefreshSelects()
        {
            _selectReport.Refresh();
            _selectSubReport?.Refresh();
            selectedReportType = "none";
            selectedSubReportType = "none";
        }

        private void CheckPlayerStatus()
        {
            //check if all players are out in a team
            foreach (var team in gameTeams)
            {
                if (!team.Players.Where(p => p.IsOut == false).Any())
                    CreateScoreReport(team);
            }
        }

        private void CreateScoreReport(Team team)
        {
            var report = new ScoreReport(Game.GameTime)
            {
                Title = "",
                ReportMessage = "All players are out in " + team.Name,
                ScoredTeam = gameTeams.FirstOrDefault(t => t.Id != team.Id)
            };

            Game.GameTime = report.Time;
            SetGameScore(report.ScoredTeam);

            report.HomeScore = Game.HomeScore;
            report.AwayScore = Game.AwayScore;

            Game.ScoreReports.Add(report);
            ResetRound();
        }

        private void SetGameScore(Team team)
        {
            if (team.Id == Game.HomeTeam.Id)
                Game.HomeScore++;
            else
                Game.AwayScore++;
        }

        private void CreateGeneralReport(string title, string message)
        {
            var report = new GeneralReport(Game.GameTime)
            {
                Title = title,
                ReportMessage = message
            };
            Game.GameTime = report.Time;
            Game.GeneralReports.Add(report);
        }

        private void ResetRound()
        {
            foreach (var team in gameTeams)
            {
                foreach (var player in team.Players)
                    player.IsOut = false;
            }

            CreateGeneralReport("Game Reset", "All players are returning to the court and the next game will start soon.");
        }
    }
}
