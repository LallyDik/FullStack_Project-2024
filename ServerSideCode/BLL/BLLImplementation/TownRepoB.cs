using BLL.BLLApi;
using BLL.BLLModels;
using DAL.DALImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation;

public class TownRepoB : ITownRepoB
{
    TownRepoD TownRepoD;
    public TownRepoB()
    {
        TownRepoD = new TownRepoD();
    }

    public async Task<List<TownB>> GetAllTownsInRegionAsync(int regionCode)
    {
        var TownsD = await TownRepoD.GetAllTownsAsync(regionCode);
        var TownsB = new List<TownB>();
        foreach (var Town in TownsD)
        {
            TownsB.Add(new TownB(Town.Code, Town.TownName));
        }
        return TownsB;
    }

}
