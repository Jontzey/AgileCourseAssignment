using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Highscore
    {
        private List<HighScoreModel> highscorelist = new List<HighScoreModel>();
        private List<HighScoreModel> filteredHighScoreList = new List<HighScoreModel>();
        private string Searcher = "";


        private int playerCount = 0;
        
        protected override async void OnInitialized()
        {
            highscorelist = await scoreService.GetAllScore();
            List<HighScoreModel> _HighScoreModel = new();
            _HighScoreModel = highscorelist;


            
            playerCount = _HighScoreModel.Count(a => !string.IsNullOrEmpty(a.Name));

            highscorelist = highscorelist.OrderByDescending(a => a.Score).ToList();

            filteredHighScoreList = highscorelist;

            StateHasChanged();
           
        }

        
        private void searchHighScoreList(ChangeEventArgs e)
        {
            Searcher = e.Value.ToString();
            if (string.IsNullOrEmpty(Searcher))
            {
                filteredHighScoreList = highscorelist;
            }
            else
            {
                filteredHighScoreList = highscorelist.Where(player => player.Name.ToLower().Contains(Searcher.ToLower())).ToList();

                
                


            }
           
        }
    
        public class PlayerIndexHighScore
        {
            public string IndexForPlayer { get; set; }

            public int PlayerPoints {get; set;}


        }
    
    
    }




}
