using BLL;
using BLL.BLLApi;
using BLL.BLLModels;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TownsController : ControllerBase
{
    BLLManager bll;
    public TownsController()
    {
        bll = new BLLManager();
    }

    [HttpGet("{regionCode}")]
    public async Task<ActionResult<List<TownB>>> GetTownsInRegionAsync(int regionCode)
    {
        return await bll.TownRepo.GetAllTownsInRegionAsync(regionCode);
    }
}
