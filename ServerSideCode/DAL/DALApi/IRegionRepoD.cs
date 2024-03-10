using DAL.DALModels;
using DBAcsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

public interface IRegionRepoD
{
    Task<List<Region>> GetAllRegionsAsync();
}
