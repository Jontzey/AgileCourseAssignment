using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Client.Services
{
    public interface IHighScoreService
    {
        public Task<List<HighScoreModel>> GetAllScore();
        public Task<HighScoreModel> GetScoreId(int Id);
        Task<HighScoreModel> AddScoreAsync(HighScoreModel playerScore);

    }
}
