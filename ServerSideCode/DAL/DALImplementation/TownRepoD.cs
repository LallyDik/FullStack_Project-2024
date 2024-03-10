using DAL.DALApi;
using DAL.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.DALImplementation;

public class TownRepoD : ITownRepoD
{
    CottagesContext Context = new CottagesContext();

    public TownRepoD()
    {
    }

    //public TownRepoD(CottagesContext context)
    //{
    //    Context = context;
    //}


    public async Task<List<Town>> GetAllTownsAsync(int regionCode)
    {
        var towns = await Context.Towns.ToListAsync();
        var t = towns.Where(t => t.RegionCode == regionCode).ToList();
        return towns.Where(t => t.RegionCode == regionCode).ToList();
    }
}
