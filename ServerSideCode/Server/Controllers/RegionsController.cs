using BLL.BLLApi;
using BLL.BLLModels;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
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
    }
}
