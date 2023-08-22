using AgileCourseAssignment.Server.Data;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace AgileCourseAssignment.Server.Repo
{


    public class FlagRepo:IFlagRepo
    {
        private readonly FlagScapeDb _flagScapeDb;

        public FlagRepo(FlagScapeDb context) 
        {
            _flagScapeDb = context;
        }


        public Task<List<FlagsModel>> GetFlagsAsync()
        {

            return _flagScapeDb.Flags.ToListAsync();
        }

        public async Task <ActionResult<FlagsModel>>GetRandomFlag(int Id)
        {
            int MaximumId = await _flagScapeDb.Flags.MaxAsync(x => x.Id);
            Random randomiser = new Random();
            int RandomId = randomiser.Next(1, MaximumId + 1);

            FlagsModel flagsmodel = await _flagScapeDb.Flags.FirstOrDefaultAsync(x => x.Id == RandomId);

            if (flagsmodel != null) 
            {
                return flagsmodel;

            }
            return null;


        }




    }
}
