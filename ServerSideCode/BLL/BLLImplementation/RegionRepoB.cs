using BLL.BLLApi;
using BLL.BLLModels;
using DAL.DALImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation;

public class RegionRepoB : IRegionRepoB
{
    RegionRepoD RegionRepoD;
    public RegionRepoB()
    {
        RegionRepoD = new RegionRepoD();
    }
    public async Task<List<RegionB>> GetAllRegionsAsync()
    {
        var regionsD = await RegionRepoD.GetAllRegionsAsync();
        var regionsB = new List<RegionB>();
        foreach (var region in regionsD)
        {
            regionsB.Add(new RegionB(region.Code, region.RegionName));
        }
        return regionsB;
    }
}
