using BLL;
using BLL.BLLApi;
using BLL.BLLModels;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegionsController : ControllerBase
{
    BLLManager bll;
    public RegionsController()
    {
        bll = new BLLManager();
    }

    [HttpGet]
    public async Task<ActionResult<List<RegionB>>> GetRegionsAsync()
    {
        await Console.Out.WriteLineAsync("tuytuy");
        return await bll.RegionRepo.GetAllRegionsAsync();
    }
}
