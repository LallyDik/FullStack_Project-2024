using BLL.BLLModels;
using BLL;
using Common;
using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CottagesController : ControllerBase
{
    BLLManager bll;
    public CottagesController()
    {
        bll = new BLLManager();
    }

    [HttpGet("{cottageCode}")]
    public async Task<ActionResult<CottagePageB>> GetCottageAsync(int cottageCode)
    {
        var c = await bll.CottagePageRepo.GetCottageAsync(cottageCode);
        if (c == null)
        {
            return NotFound();
        }
        return Ok(c);
    }

    [HttpPut]
    public async Task<ActionResult<int>> AddCottageAsync([FromBody] CottagePageB cottagePage)
    {
        var c = await bll.CottagePageRepo.AddCottageAsync(cottagePage);
        if (c == 0)
        {
            return BadRequest();
        }
        return Ok(c);
    }
    [HttpPost]
    public async Task<ActionResult<bool>> UpdateCottageAsync([FromBody] CottagePageB cottagePage, int confirmCode)
    {
        var c = await bll.CottagePageRepo.UpdateCottageAsync(cottagePage,confirmCode);
        if (!c)
        {
            return BadRequest();
        }
        return Ok(c);
    }

    [HttpDelete]   
    public async Task<ActionResult<bool>> DeleteAsync([FromBody] int cottageCode, int confirmCode)
    {
        var c = await bll.CottagePageRepo.DeleteAsync(cottageCode, confirmCode);
        if (!c)
        {
            return BadRequest();
        }
        return Ok(c);
    }
}
