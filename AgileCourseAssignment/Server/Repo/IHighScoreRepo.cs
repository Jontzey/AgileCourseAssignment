using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Server.Repo
{
    public interface IHighScoreRepo
    {
        Task <List<HighScoreModel>> GetHighScoreAsync();
    }
}
