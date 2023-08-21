using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Server.Repo
{
    public interface IFlagRepo
    {

        Task <List<FlagsModel>> GetFlagAsync();
    }
}
