using AgileCourseAssignment.Client.Services;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class WikiFlags
    {

        //[Inject]
        //private IFlagService wikiService { get; set; }
        private static List<FlagsModel> flagList = new();

        protected override async void OnInitialized()
        {
            flagList = await wikiService.GetAllFlags();

            StateHasChanged();

        }
      
        private void NavigateToHome()
        {
            Navigation.NavigateTo("/");
        }

    }
}
