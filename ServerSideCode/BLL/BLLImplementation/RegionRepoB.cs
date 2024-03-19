using BLL.BLLApi;
using BLL.BLLModels;
using DAL;
using DAL.DALImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation;

public class RegionRepoB : IRegionRepoB
{
    DALManager dal;
    public RegionRepoB()
    {
        dal = new DALManager();
    }
    public async Task<List<RegionB>> GetAllRegionsAsync()
    {
        var regionsD = await dal.Regions.GetAllRegionsAsync();
        var regionsB = new List<RegionB>();
        foreach (var region in regionsD)
        {
            regionsB.Add(new RegionB(region.Code, region.RegionName));
        }
        return regionsB;
    }
}
