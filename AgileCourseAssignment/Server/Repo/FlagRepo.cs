using AgileCourseAssignment.Server.Data;
using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileCourseAssignment.Server.Repo
{


    public class FlagRepo:IFlagRepo
    {
        private readonly FlagScapeDb _flagScapeDb;

        public FlagRepo(FlagScapeDb context) 
        {
            _flagScapeDb = context;
        }


        public Task<List<FlagsModel>> GetFlagAsync()
        {

            return _flagScapeDb.Flags.ToListAsync();
        }



    }
}
