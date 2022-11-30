using Microsoft.AspNetCore.Components;

namespace Blazor.Controls
{
    public partial class DropDownItem<TItem> : ComponentBase
    {
        [CascadingParameter]
        public DropDown<TItem>? DropDown { get; set; }
        [Parameter]
        public TItem? Item { get; set; }
        [Parameter]
        public RenderFragment<TItem>? Label { get; set; }

        private async Task OnMouseDown()
        {
            if (DropDown != null)
            {
                await DropDown.HandleSelect(Item, Label);
            }
        }

        private RenderFragment? RenderLabel => Label != null && Item != null ? Label(Item) : null;
    }
}
