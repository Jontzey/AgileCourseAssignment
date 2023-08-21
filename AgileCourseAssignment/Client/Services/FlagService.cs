using AgileCourseAssignment.Shared.Models;
using System.Net.Http.Json;

namespace AgileCourseAssignment.Client.Services
{
    

    public class FlagService : IFlagService
    {
        private readonly HttpClient httpClient;

        public List<FlagsModel> Flags { get; set; } = new();
        public FlagService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;  
        }

        public async Task<List<FlagsModel>> GetAllFlags()
        {
            var response = await httpClient.GetAsync("api/Flags");

            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<FlagsModel>>();
            }
            return null;
        }

        public Task<FlagsModel> GetSingleFlag(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
