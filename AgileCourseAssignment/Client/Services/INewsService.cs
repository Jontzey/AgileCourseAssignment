using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Client.Services
{
    public interface INewsService
    {


        public Task<List<News>> GetNews();
    }
}
