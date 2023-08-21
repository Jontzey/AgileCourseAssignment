using AgileCourseAssignment.Shared.Models;

namespace AgileCourseAssignment.Client.Services
{
    public interface IFlagService
    {

        public Task<List<FlagsModel>> GetAllFlags();

        public Task<FlagsModel> GetSingleFlag(int Id);

                
      


    }
}
