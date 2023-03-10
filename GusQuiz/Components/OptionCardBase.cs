using Microsoft.AspNetCore.Components;

namespace GusQuiz.Components
{
    public class OptionCardBase : ComponentBase
    {
        [Parameter]
        public string Option { get; set; } = string.Empty;
        public string Option2 { get; set; } = string.Empty;
        [Parameter]
        public EventCallback<string> OnOptionSelected { get; set; }

        protected async void SelectOption()
        {
            await OnOptionSelected.InvokeAsync(Option);
        }
    }
}
