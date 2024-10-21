using Microsoft.AspNetCore.Components;

namespace Stocks.WEB.Components.Pages.ReusableComponents
{
    public partial class Paginator
    {

        // [EditorRequired] attribute: If a value for this parameter is not provided, editors or build tools may provide
        //     warnings indicating the user to specify a value. This attribute is only valid
        //     on properties marked with Microsoft.AspNetCore.Components.ParameterAttribute.
        [Parameter]
        [EditorRequired]
        public int CurrentPage { get; set; }

        [Parameter]
        [EditorRequired]
        public int TotalPages { get; set; }

        [Parameter]
        public EventCallback<int> OnPageChange { get; set; }

        private async Task NavigateTo(string direction)
        {
            if (direction.Equals("next") && CurrentPage < TotalPages)
            {
                CurrentPage++;
            }
            else if (direction.Equals("prev") && CurrentPage > 1)
            {
                CurrentPage--;
            }
            else if (direction.Equals("first"))
            {
                CurrentPage = 1;
            }
            else if (direction.Equals("last"))
            {
                CurrentPage = TotalPages;
            }
            await OnPageChange.InvokeAsync(CurrentPage);
        }
    }
}
