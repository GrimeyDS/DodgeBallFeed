using Microsoft.AspNetCore.Components;
using Pin.LiveSports.Core.Entities.Games;

namespace Pin.LiveSports.Blazor.Components.Viewing
{
    public class BaseGameComponent : ComponentBase
    {
        [Parameter]
        public Game Game { get; set; }
    }
}
