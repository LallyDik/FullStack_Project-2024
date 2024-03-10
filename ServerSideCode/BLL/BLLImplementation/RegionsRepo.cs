using BLL.BLLApi;
using BLL.BLLModels;
using DAL.DALImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation;

public class RegionsRepo : IRegionsRepo
{
    RegionRepo regionRepo = new RegionRepo();
    public RegionsRepo() { }
    //public RegionsRepo(RegionRepo regionRepo)
    //{
    //    this.regionRepo = regionRepo;
    //}

    public async Task<List<Regions>> GetAllRegionsAsync()
    {
        var regionList = await regionRepo.GetAllAsync();
        var regions = new List<Regions>();
        foreach (var region in regionList)
        {
            regions.Add(new Regions(region.RegionName, region.Code));
        }
        return regions;
    }
}





