using Common;
using DAL.DALApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class RegionRepo : IRegionRepo
{
    HolidayCottage
    public Task<Region> AddAsync(Region entity)
    {
        throw new NotImplementedException();
    }

    public Task<Region> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Region>> GetAllAsync(BaseQueryParams queryParams)
    {
        return await 
    }

    public Task<Region> GetSingleAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Region> UpdateAsync(Region entity)
    {
        throw new NotImplementedException();
    }
}
