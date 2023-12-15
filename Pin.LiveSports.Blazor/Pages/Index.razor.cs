using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Pin.LiveSports.Blazor.Services;
using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Services;

namespace Pin.LiveSports.Blazor.Pages
{
    public partial class Index
    {
        [Inject] ITeamService TeamService { get; init; }

        private bool isReporter = false;
        private ReportClient reportClient;
        private readonly List<Game> games = [];
        private Team[] teams;

        private Game currentGame;

        protected async override Task OnInitializedAsync()
        {
            teams = TeamService.GetTeams().ToArray();
            reportClient = new ReportClient();
            reportClient.Configure(OnRemoteReport);
            await reportClient.StartAsync();
        }

        private async Task AddReport(Game game)
        {
            if (!games.Where(g => g.Id == game.Id).Any())
                games.Add(game);
            else
            {
                var oldGame = games.Where(g => g.Id == game.Id).FirstOrDefault();
                oldGame = game;
            }
            await reportClient.AddItemAsync(game);
        }

        private void OnRemoteReport(string json)
        {
            Game game = JsonConvert.DeserializeObject<Game>(json);

            if (!games.Where(g => g.Id == game.Id).Any())
                games.Add(game);
            else
            {
                var oldGame = games.Where(g => g.Id == game.Id).FirstOrDefault();

                // oldGame = game does not work due to reference
                oldGame.TeamChangeReports = game.TeamChangeReports;
                oldGame.GeneralReports = game.GeneralReports;
                oldGame.FoulReports = game.FoulReports;
                oldGame.SuddenDeathReports = game.SuddenDeathReports;
                oldGame.ScoreReports = game.ScoreReports;
                oldGame.WinReports = game.WinReports;
                oldGame.HomeScore = game.HomeScore;
                oldGame.AwayScore = game.AwayScore;
                oldGame.GameTime = game.GameTime;
                oldGame.HomeTeam = game.HomeTeam;
                oldGame.AwayTeam = game.AwayTeam;
            }

            StateHasChanged();
        }

        private void ChangeUser()
        {
            isReporter = !isReporter;
        }

        private void ChangeCurrentGame(Game game)
        {
            currentGame = game;
        }
    }
}
