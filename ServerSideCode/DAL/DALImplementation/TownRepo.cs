﻿using Common;
using DAL.DALApi;
using DAL.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class TownRepo : ITownRepo
{
    HolidayContext Context;
    public TownRepo(HolidayContext context)
    {
        Context = context;
    }


    public async Task<List<Town>> GetAllAsync(int regionCode)
    {
        var lst = await Context.Towns.ToListAsync();
        return lst.Where(x => x.RegionCode == regionCode).ToList(); ;
    }
}
