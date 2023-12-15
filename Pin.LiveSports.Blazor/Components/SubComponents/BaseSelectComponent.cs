using Microsoft.AspNetCore.Components;

namespace Pin.LiveSports.Blazor.Components.SubComponents
{
    public abstract class BaseSelectComponent : ComponentBase
    {
        [Parameter]
        public EventCallback<Guid> OnSelect { get; set; }

        protected Guid id;
    }
}
