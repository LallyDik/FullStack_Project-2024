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
    CottagesContext Context;

    public TownRepoD(CottagesContext context)
    {
        Context = context;
    }

    public async Task<List<Town>> GetAllTownsAsync(int regionCode)
    {
        var towns = await Context.Towns.ToListAsync();
        return towns.Where(t => t.RegionCode == regionCode).ToList();
    }
    public string GetTownName(int townCode)
    {
        return Context.Towns.Where(t => t.Code == townCode).FirstOrDefault().TownName;
    }
    public int GetTownCode(string townName)
    {
        return Context.Towns.Where(r => r.TownName == townName).FirstOrDefault().Code;
    }
}
