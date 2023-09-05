using AgileCourseAssignment.Server.Repo;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgileCourseAssignment.Server.Controllers
{
     [ApiController]
     [Route("api/[controller]")]
    public class FlagsController : Controller
    {
        // Loading the data to webserver(json) to accsess write following
        //url path should be /flags, like /playground.

        //field variables
        private readonly IFlagRepo _flagRepo;

        public FlagsController(IFlagRepo flagRepo) {
        
            this._flagRepo = flagRepo;
        }

        // upload data to json
        [HttpGet]
        public async Task<List<FlagsModel>?> GetTestFlagsAsync()
        {
            return await _flagRepo.GetFlagsAsync();
        }
    }
}
