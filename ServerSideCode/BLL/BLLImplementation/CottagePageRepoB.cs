using BLL.BLLApi;
using BLL.BLLModels;
using DAL;
using DAL.DALImplementation;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation;

public class CottagePageRepoB : ICottagePageRepoB
{
    DALManager dal;
    public CottagePageRepoB()
    {
        dal = new DALManager();
    }
    public async Task<int> AddCottageAsync(CottagePageB cottagePage)
    {
        try
        {
            Random generator = new Random();
            int code = generator.Next(100000, 1000000);
            var codes = dal.Cottages.GetConfirmsCodes();
            while (codes.Contains(code))
            {
                code = generator.Next(100000, 1000000);
            }
            var regionCode = dal.Regions.GetRegionCode(cottagePage.RegionName);
            var townCode = dal.Towns.GetTownCode(cottagePage.TownName);
            var cottage = new Cottage(cottagePage.CottageName, regionCode, townCode, cottagePage.NumOfBeds,
                cottagePage.NumOfRooms, cottagePage.Stars, cottagePage.PriceToNight, cottagePage.Description, code);
            dal.CottagePage.AddCottageAsync(cottage);
            return code;
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Faild to add new Cottage");
        }
    }

    public bool CheckConfirmCode(int cottageCode, int confirmCode)
    {
        return dal.CottagePage.CheckConfirmCode(cottageCode, confirmCode);
    }

    public Task<bool> DeleteAsync(int cottageCode, int confirmCode)
    {
        if (CheckConfirmCode(cottageCode, confirmCode))
        {
            dal.CottagePage.DeleteAsync(cottageCode);
            return Task.FromResult(true);
        }
        return Task.FromResult(false);

    }

    public async Task<CottagePageB> GetCottageAsync(int cottageCode)
    {
        var cottage = await dal.CottagePage.GetCottageAsync(cottageCode);
        var regionName = dal.Regions.GetRegionName(cottage.RegionCode);
        var townName = dal.Towns.GetTownName(cottage.TownCode);
        var pictures = await dal.Pictures.GetPictureOfCottageAsync(cottageCode);
        return new CottagePageB(cottage.Code, cottage.CottageName, regionName, townName, cottage.NumOfBeds, cottage.NumOfRooms, 
            cottage.Stars, cottage.PriceToNight, cottage.Description, pictures);
    }

    public async Task<bool> UpdateCottageAsync(CottagePageB cottagePage, int confirmCode)
    {
        try
        {
            if (CheckConfirmCode(cottagePage.Code, confirmCode))
            {
                var regionCode = dal.Regions.GetRegionCode(cottagePage.RegionName);
                var townCode = dal.Towns.GetTownCode(cottagePage.TownName);
                var lastCottage = await dal.CottagePage.GetCottageAsync(cottagePage.Code);
                var cottage = new Cottage(cottagePage.CottageName, regionCode, townCode, cottagePage.NumOfBeds,
                    cottagePage.NumOfRooms, cottagePage.Stars, cottagePage.PriceToNight, cottagePage.Description, lastCottage.ConfirmCode);
                dal.CottagePage.UpdateCottageAsync(cottage);
                return true;
            }
            return false;
        }catch(Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            throw new Exception("Faild to apdate the Cottage");
        }
    }

  
}
