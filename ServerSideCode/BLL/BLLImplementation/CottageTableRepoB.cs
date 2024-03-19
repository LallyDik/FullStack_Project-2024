using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL;
using DAL.DALModels;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation;

public class CottageTableRepoB : ICottageTableRepoB
{
    DALManager dal;
    public CottageTableRepoB()
    {
        dal = new DALManager();
    }
    public async Task<PagedList<CottageTableB>> GetCottageTable(CottageParams cottageParams)
    {
        var cottages = await dal.Cottages.GetCottageTableAsync(cottageParams);
        var cottagesTable = new List<CottageTableB>();
        foreach(var cottage in cottages)
        {
            var regionName = dal.Regions.GetRegionName(cottage.RegionCode);
            var townName = dal.Towns.GetTownName(cottage.TownCode);
            cottagesTable.Add(new CottageTableB(cottage.CottageName, regionName, townName, cottage.NumOfBeds, cottage.NumOfRooms, cottage.Stars, cottage.PriceToNight));
        }
        return await PagedList<CottageTableB>.ToPagedListAsync(cottagesTable.OrderBy(cottage => cottage.PriceToNight).AsQueryable(),
               cottageParams.PageNumber
               , cottageParams.PageSize); 
    }

}
