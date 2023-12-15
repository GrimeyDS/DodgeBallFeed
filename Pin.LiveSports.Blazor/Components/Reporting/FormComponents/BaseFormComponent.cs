using Microsoft.AspNetCore.Components;
using Pin.LiveSports.Core.Entities.Games;
using Pin.LiveSports.Core.Entities.Reports;

namespace Pin.LiveSports.Blazor.Components.Reporting.FormComponents
{
    public abstract class BaseFormComponent : ComponentBase
    {
        [Parameter]
        public EventCallback<GeneralReport> OnSave { get; set; }

        [Parameter]
        public Team[] Teams { get; set; }

        [Parameter]
        public Game Game { get; set; }
    }
}
