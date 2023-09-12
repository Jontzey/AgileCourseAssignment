using AgileCourseAssignment.Client.Services;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class WikiFlags
    {

        //[Inject]
        //private IFlagService wikiService { get; set; }
        private static List<FlagsModel> flagList = new();

        private List<bool> isFlippedList = new List<bool>();


        protected override async void OnInitialized()
        {
            flagList = await wikiService.GetAllFlags();
            isFlippedList = Enumerable.Repeat(false, flagList.Count).ToList();

        }


        private void ToggleCard(int index)
        {
            if (index >= 0 && index < isFlippedList.Count)
            {
                isFlippedList[index] = !isFlippedList[index];
                StateHasChanged(); // Trigger a re-render to update the UI
            }
            else
            {
                // Handle the index out of range error gracefully.
                // You can display an error message or take appropriate action.
            }
        }

    }
}
