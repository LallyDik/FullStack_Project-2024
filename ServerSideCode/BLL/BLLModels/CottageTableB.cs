using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels;

public class CottageTableB
{
    public string CottageName { get; set; }

    public string RegionName { get; set; }

    public string TownName { get; set; }

    public int NumOfBeds { get; set; }

    public int NumOfRooms { get; set; }

    public int Stars { get; set; }

    public int PriceToNight { get; set; }

    public CottageTableB(string cottageName, string regionName, string townName, int numOfBeds, int numOfRooms, int stars, int priceToNight)
    {
        CottageName = cottageName;
        RegionName = regionName;
        TownName = townName;
        NumOfBeds = numOfBeds;
        NumOfRooms = numOfRooms;
        Stars = stars;
        PriceToNight = priceToNight;
    }
}
