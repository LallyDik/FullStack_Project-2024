using Common;
using DAL.DALApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class TownRepo : ITownRepo
{
    public Task<Town> AddAsync(Town entity)
    {
        throw new NotImplementedException();
    }

    public Task<Town> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Town>> GetAllAsync(BaseQueryParams queryParams)
    {
        throw new NotImplementedException();
    }

    public Task<Town> GetSingleAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Town> UpdateAsync(Town entity)
    {
        throw new NotImplementedException();
    }
}
