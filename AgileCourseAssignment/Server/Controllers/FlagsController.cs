using AgileCourseAssignment.Server.Repo;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgileCourseAssignment.Server.Controllers
{
     [ApiController]
     [Route("[controller]")]
    public class FlagsController : Controller
    {
        // Loading the data to webserver(json) to accsess write following
        //url path should be /flags, like 

        private readonly IFlagRepo _flagRepo;

        public FlagsController(IFlagRepo flagRepo) {
        
            this._flagRepo = flagRepo;
        }

        [HttpGet]
        public async Task<List<FlagsModel>?> GetTestFlagsAsync()
        {
            return await _flagRepo.GetFlagAsync();
        }
    }
}
