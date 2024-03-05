using BLL.BLLApi;
using BLL.BLLModels;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
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
       
    }
}
