
namespace Pin.LiveSports.Core.Entities.Reports
{
    public interface IGeneralReport
    {
        Guid Id { get; set; }
        string ReportMessage { get; set; }
        TimeOnly Time { get; set; }
        string Title { get; set; }
    }
}