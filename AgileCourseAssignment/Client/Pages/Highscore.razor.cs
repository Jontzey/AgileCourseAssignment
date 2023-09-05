using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Highscore
    {
        private List<HighScoreModel> highscorelist = new List<HighScoreModel>();
        protected override async void OnInitialized()
        {
            highscorelist = await scoreService.GetAllScore();
        }
    }
}
