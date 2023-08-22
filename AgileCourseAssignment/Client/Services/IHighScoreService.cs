using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Client.Services
{
    public interface IHighScoreService
    {
        public Task<List<HighScoreModel>> GetAllScore();

    }
}
