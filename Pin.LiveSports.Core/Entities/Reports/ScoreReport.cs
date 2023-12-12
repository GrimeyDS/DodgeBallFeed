namespace Pin.LiveSports.Core.Entities.Reports
{
    public class ScoreReport : GeneralReport
    {
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public Guid ScoredTeam { get; set; }
    }
}
