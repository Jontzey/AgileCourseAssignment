using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

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
        public async Task<HighScoreModel> AddScoreAsync(HighScoreModel playerScore)
        {
         
                var response = await httpClient.PostAsJsonAsync("api/HighScore", playerScore);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<HighScoreModel>(json); 
                }
           
                    Console.WriteLine($"HTTP Error: {response.StatusCode}");
                    return null;
        }

        public Task<HighScoreModel> GetScoreId(int Id)
        {
            throw new NotImplementedException();
        }


    }
}
