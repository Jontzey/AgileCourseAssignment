using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Server.Repo
{
    public interface INewsRepo
    {

        Task<List<News>> GetAllNewsAsync();
    }
}
