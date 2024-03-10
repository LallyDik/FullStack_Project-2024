using BLL.BLLApi;
using BLL.BLLModels;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
<<<<<<< HEAD
        IRegionRepoB regionRepoB;

        public RegionsController(IRegionRepoB regionRepoB) 
        {
            this.regionRepoB = regionRepoB;
        }

        [HttpGet]
        public async Task<ActionResult<List<RegionB>>> GetRegionsAsync()
        {
            return await regionRepoB.GetAllRegionsAsync();
        }
=======
        IRegionsRepo regionsRepo;
        public RegionsController(IRegionsRepo regionsRepo)
        {
            this.regionsRepo = regionsRepo;
        }

        [HttpGet]
        public async Task<List<Regions>> GetAllRegionsAsync()
        {
            return await regionsRepo.GetAllRegionsAsync();
        }
       
>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497
    }
}
