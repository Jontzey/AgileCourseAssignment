using AgileCourseAssignment.Server.Repo;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgileCourseAssignment.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HighScoreController : Controller
    {

        private readonly IHighScoreRepo _highScoreRepo;
        public HighScoreController(IHighScoreRepo highScoreRepo)
        {
            this._highScoreRepo = highScoreRepo;
        }

        [HttpGet]

        public async Task<List<HighScoreModel>?> GetHighScores()
        {
            return await _highScoreRepo.GetHighScoreAsync();
        }

        [HttpPost]
        public async Task<ActionResult<HighScoreModel>> AddScoreAsync([FromBody] HighScoreModel highscore)
        {
            var highscoreWasAdded = await _highScoreRepo.AddScoreAsync(highscore);

            if (highscoreWasAdded)
            {
                return Ok(highscore);
            }

            return BadRequest();
        }
    }
}
