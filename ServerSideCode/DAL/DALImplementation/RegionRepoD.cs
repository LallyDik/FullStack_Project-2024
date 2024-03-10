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
    CottagesContext Context = new CottagesContext();

    public RegionRepoD()
    {
    }

    //public RegionRepoD(CottagesContext context)
    //{
    //    Context = context;
    //}

    public async Task<List<Region>> GetAllRegionsAsync()
    {
        return await Context.Regions.ToListAsync();
    }
}
