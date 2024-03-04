using Common;
using DAL.DALApi;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class RegionRepo : IRegionRepo
{
    HolidayContext Context;
    public RegionRepo(HolidayContext context)
    {
        Context = context;
    }

    public async Task<List<Region>> GetAllAsync(BaseQueryParams queryParams)
    {
        return await Context.Regions.ToListAsync();
    }
}
