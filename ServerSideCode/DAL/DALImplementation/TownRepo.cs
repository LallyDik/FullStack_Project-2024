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

public class TownRepo : ITownRepo
{
    HolidayContext Context;
    public TownRepo(HolidayContext context)
    {
        Context = context;
    }

    public async Task<List<Town>> GetAllAsync(BaseQueryParams queryParams)
    {
        return await Context.Towns.ToListAsync();
    }
}
