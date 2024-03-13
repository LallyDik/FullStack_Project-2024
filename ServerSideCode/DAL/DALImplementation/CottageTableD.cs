using Common;
using DAL.DALApi;
using DAL.DALModels;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class CottageTableD : ICottageTableD
{
    CottagesContext Context;

    public CottageTableD(CottagesContext context)
    {
        Context = context;
    }
    public async Task<List<Cottage>> GetCottageTableAsync(BaseQueryParams queryParams)
    {
        var cottageParams = queryParams as CottageParams;
        var queryable = Context.Cottages.AsQueryable();
        if (cottageParams.RegionCode != 0)
        {
            queryable = queryable.Where(c => c.RegionCode == cottageParams.RegionCode);
        }
        if (cottageParams.TownCode != 0)
        {
            queryable = queryable.Where(c => c.TownCode == cottageParams.TownCode);
        }
        if (cottageParams.Stars != 0)
        {
            queryable = queryable.Where(c => c.Stars == cottageParams.Stars);
        }
        if (cottageParams.NumOfBeds != 0)
        {
            queryable = queryable.Where(c => c.NumOfBeds == cottageParams.NumOfBeds);
        }
        if (cottageParams.PriceToNight != 0)
        {
            queryable = queryable.Where(c => c.PriceToNight == cottageParams.PriceToNight);
        }
        return await PagedList<Cottage>.ToPagedListAsync(queryable.OrderBy(u => u.PriceToNight),
               cottageParams.PageNumber
               ,cottageParams.PageSize);

    }

}
