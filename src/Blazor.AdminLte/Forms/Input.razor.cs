using Microsoft.AspNetCore.Components;

namespace Blazor.AdminLte
{
    public partial class Input
    {
        private const string DefaultStyles = "input-group mb-3";

        [Parameter]
        public InputState Value { get; set; }

        [Parameter]
        public string Styles { get; set; } = DefaultStyles;

        [Parameter]
        public EventCallback<InputState> ValueChanged { get; set; }

        [Parameter]
        public EventCallback<InputState> OnChange { get; set; }

        private void DoChange(ChangeEventArgs e)
        {
            Value.Value = (string)e.Value;
            ValueChanged.InvokeAsync(Value);
            if (OnChange.HasDelegate)
                OnChange.InvokeAsync(Value);
        }
    }
}
