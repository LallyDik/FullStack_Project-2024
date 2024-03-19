using DAL.DALApi;
using DAL.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class RegionRepoD : IRegionRepoD
{
    CottagesContext Context; 

    public RegionRepoD(CottagesContext context)
    {
        Context = context;
    }

    public async Task<List<Region>> GetAllRegionsAsync()
    {
        return await Context.Regions.ToListAsync();
    }
    public string GetRegionName(int regionCode)
    { 
       return Context.Regions.Where(r => r.Code == regionCode).FirstOrDefault().RegionName; 
    }
    public int GetRegionCode(string regionName)
    {
        return Context.Regions.Where(r => r.RegionName == regionName).FirstOrDefault().Code;
    }
}
