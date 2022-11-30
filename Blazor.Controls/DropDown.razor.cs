using Microsoft.AspNetCore.Components;

namespace Blazor.Controls
{
     public partial class DropDown<TItem>
    {
        [Parameter]
        public RenderFragment? Label { get; set; }
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
        [Parameter]
        public EventCallback<TItem> OnSelected { get; set; }
        private bool Show { get; set; } = false;
        private void OnMouseDown()
        {
            Show = !Show;
        }

        private void OnFocusOut()
        {
            Show = false;
            StateHasChanged();
        }

        public async Task HandleSelect(TItem? item, RenderFragment<TItem>? fragment)
        {
            Show = false;
            if (item != null)
            {
                Label = fragment?.Invoke(item);
                await OnSelected.InvokeAsync(item);
            }
        }
    }
}