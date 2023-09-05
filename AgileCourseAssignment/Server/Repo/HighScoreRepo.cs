using AgileCourseAssignment.Server.Data;
using AgileCourseAssignment.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileCourseAssignment.Server.Repo

{
    public class HighScoreRepo : IHighScoreRepo
    {
        private readonly FlagScapeDb _flagScapeDb;
        public HighScoreRepo(FlagScapeDb context)
        {
            _flagScapeDb = context;
        }

        public Task<List<HighScoreModel>> GetHighScoreAsync() 
        {

            return _flagScapeDb.HighScore.ToListAsync();
        }

        public async Task<bool> AddScoreAsync(HighScoreModel highScore)
        {
            try
            {
                if (!await _flagScapeDb.HighScore.AnyAsync(e => e.Name == highScore.Name))
                {
                    _flagScapeDb.Add(highScore);
                    await _flagScapeDb.SaveChangesAsync();

                    if (await _flagScapeDb.HighScore.AnyAsync(e => e.Name == highScore.Name))
                    {
                        return true;
                    }
                }
                    return false;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
