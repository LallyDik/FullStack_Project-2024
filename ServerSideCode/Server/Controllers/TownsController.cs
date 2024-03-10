using BLL.BLLApi;
using BLL.BLLModels;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownsController : ControllerBase
    {
        ITownRepoB TownRepoB;

        public TownsController(ITownRepoB TownRepoB)
        {
            this.TownRepoB = TownRepoB;
        }
        [HttpGet("{TownCode}")]
        public async Task<ActionResult<List<TownB>>> GetTownsInRegionAsync(int regionCode)
        {
            return await TownRepoB.GetAllTownsInRegionAsync(regionCode);
        }
    }
}
