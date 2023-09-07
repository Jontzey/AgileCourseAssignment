using AgileCourseAssignment.Server.Data;
using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileCourseAssignment.Server.Repo
{
    public class NewsRepo:INewsRepo
    {


        private readonly FlagScapeDb _flagScapeDb;

        public NewsRepo(FlagScapeDb context)
        {
            this._flagScapeDb = context;
        }


        public Task<List<News>> GetAllNewsAsync()
        {

            return _flagScapeDb.News.ToListAsync();
        }
    }
}
