using AgileCourseAssignment.Shared.Models;
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

        public Task<HighScoreModel> GetScoreId(int Id)
        {
            throw new NotImplementedException();
        }


    }
}
