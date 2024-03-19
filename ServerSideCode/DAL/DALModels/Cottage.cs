using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Cottage
{
    public int Code { get; }

    public string CottageName { get; }

    public int RegionCode { get; }

    public int TownCode { get; }

    public int NumOfBeds { get; }

    public int NumOfRooms { get; }

    public int Stars { get; }

    public int PriceToNight { get; }

    public string Description { get; }

    public int ConfirmCode { get; }

    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

    public virtual Region RegionCodeNavigation { get; set; }

    public virtual Town TownCodeNavigation { get; set; }
    public Cottage(string cottageName, int regionCode, int townCode, int numOfBeds, int numOfRooms,
    int stars, int priceToNight, string description, int confirnCode)
    {
        CottageName = cottageName;
        RegionCode = regionCode;
        TownCode = townCode;
        NumOfBeds = numOfBeds;
        NumOfRooms = numOfRooms;
        Stars = stars;
        PriceToNight = priceToNight;
        Description = description;
        ConfirmCode = confirnCode;
    }
}
