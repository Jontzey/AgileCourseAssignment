using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Highscore
    {
        private List<HighScoreModel> highscorelist;
        protected override async void OnInitialized()
        {
            highscorelist = await scoreService.GetAllScore();
        }
    }
}
