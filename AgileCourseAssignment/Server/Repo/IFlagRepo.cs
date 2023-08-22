using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgileCourseAssignment.Server.Repo
{
    public interface IFlagRepo
    {

        Task <List<FlagsModel>> GetFlagsAsync();

        public Task<ActionResult<FlagsModel>> GetRandomFlag(int Id);
    }
}
