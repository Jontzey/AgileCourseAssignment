using AgileCourseAssignment.Client.Services;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Serialization;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Menu
    {
        [Inject]
        private INewsService News { get; set; } 
 
        private List<News> allNews = new List<News>();
        private News CurrentNews;
        //TEST
        private bool isImg;
        private string imgTop = "0px";

        // NEWS container
        private bool isHovering = false;
        protected override async void OnInitialized()
        {
            try
            {
                allNews = await News.GetNews();
                Console.WriteLine(allNews.Count);
                StateHasChanged();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Handle the exception gracefully, e.g., display an error message.
            }
        }


        private void NavigateToPlayground()
        {
            Navigation.NavigateTo("/playground");
        }
        private void NavigateToPlayground2()
        {

            Navigation.NavigateTo("/playground2");
        }

        private void NavigateToHome()
        {
            Navigation.NavigateTo("/");
        }
        private void ActivateImg(int currentButon)
        {
            if (currentButon == 1)
            {
                isImg = true;
                imgTop = "-12px";

            }
            else if (currentButon == 2)
            {

                isImg = true;
                imgTop = "35px";
            }
            else if (currentButon == 3)
            {
                isImg = true;
                imgTop = "81px";
            }

        }

        private void DeactivateImg()
        {
            isImg = false;
        }
    }
}
