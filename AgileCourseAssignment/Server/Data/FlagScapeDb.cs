using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileCourseAssignment.Server.Data
{
    public class FlagScapeDb:DbContext
    {


        public FlagScapeDb(DbContextOptions<FlagScapeDb> options) : base(options)
        { 

        }

        public DbSet<FlagsModel> Flags { get; set; }
    }
}
