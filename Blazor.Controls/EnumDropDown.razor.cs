using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Blazor.Controls
{
    /// <summary>
    /// A custom Blazor dropdown component that can handle enums with descriptions that contain spaces. 
    /// </summary>
    public partial class EnumDropDown<TEnum> where TEnum : struct, Enum?
    {
        [Parameter]
        public EventCallback<TEnum?> Callback { get; set; }
        [Parameter]
        public TEnum? Selected { get; set; } = null;
        [Parameter]
        public string DefaultLabel { get; set; } = "Select";
        public string? Label => Selected == null ? DefaultLabel : Selected.DisplayName();
        private bool Show { get; set; } = false;

        private void OnFocusOut()
        {
            Show = false;
            StateHasChanged();
        }

        public void OnLabelMouseDown()
        {
            Show = !Show;
        }

        public async Task OnItemMouseDown(TEnum? item)
        {
            Show = false;
            if (item != null)
            {
                if (Callback.HasDelegate)
                {
                    await Callback.InvokeAsync(item);
                }
            }
        }
    }
}
