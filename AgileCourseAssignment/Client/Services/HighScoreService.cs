using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Net.Http.Json;

namespace AgileCourseAssignment.Client.Services
{
    public class HighScoreService : IHighScoreService
    {
        private readonly HttpClient httpClient;

        public List<HighScoreModel> Score { get; set; } = new();

        public HighScoreService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }
        public async Task<List<HighScoreModel>> GetAllScore()
        {
            var response = await httpClient.GetAsync("api/HighScore");

            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<HighScoreModel>>();

            }

            return null;
        }

        public async Task<bool> RegisterScoreAsync(HighScoreModel playerScore)
        {
            {
                try
                {
                    // Add the player's score to the database
                    httpClient.HighScoreModel.Add(playerScore);
                    await httpClient.SaveChangesAsync();
                    return true; // Registration was successful
                }
                catch (Exception)
                {
                    return false; // Registration failed
                }
            }
        }

        public Task<HighScoreModel> GetScoreId(int Id)
        {
            throw new NotImplementedException();
        }


    }
}
