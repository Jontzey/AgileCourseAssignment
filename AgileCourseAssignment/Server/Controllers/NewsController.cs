using AgileCourseAssignment.Server.Repo;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgileCourseAssignment.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : Controller
    {



        private readonly INewsRepo _NewsRepo;

        public NewsController(INewsRepo NewsRepo)
        {

            this._NewsRepo = NewsRepo;
        }

        // upload data to json
        [HttpGet]
        public async Task<List<News>?> GetAllNews()
        {
            return await _NewsRepo.GetAllNewsAsync();
        }
    }
}
