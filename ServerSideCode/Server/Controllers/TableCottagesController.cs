using BLL;
using BLL.BLLModels;
using Common;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TableCottagesController : ControllerBase
{
    BLLManager bll;
    public TableCottagesController()
    {
        bll = new BLLManager();
    }

    [HttpGet]
    public async Task<ActionResult<PagedList<CottageTableB>>> GetCottagestableAsync([FromQuery] CottageParams cottageParams)
    {
        return await bll.CottageTableRepo.GetCottageTable(cottageParams);
    }
}
