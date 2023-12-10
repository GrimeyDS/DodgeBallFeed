using Pin.LiveSports.Core.Entities.Games;

namespace Pin.LiveSports.Core.Services
{
    public interface ITeamService
    {
        IEnumerable<Team> GetTeams();
    }
}