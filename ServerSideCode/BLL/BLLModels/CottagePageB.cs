using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels;

public class CottagePageB
{
    public int Code { get; set; }
    public string CottageName { get; }

    public string RegionName { get;}

    public string TownName { get; }

    public int NumOfBeds { get; }

    public int NumOfRooms { get;}

    public int Stars { get; }

    public int PriceToNight { get; }

    public string Description { get; }
    public List<Picture> PictureList { get; }

    public CottagePageB(int code, string cottageName, string regionName, string townName, int numOfBeds, int numOfRooms, 
        int stars, int priceToNight, string description, List<Picture> pictureList)
    {
        Code = code;
        CottageName = cottageName;
        RegionName = regionName;
        TownName = townName;
        NumOfBeds = numOfBeds;
        NumOfRooms = numOfRooms;
        Stars = stars;
        PriceToNight = priceToNight;
        Description = description;
        PictureList = pictureList;
    }
}
