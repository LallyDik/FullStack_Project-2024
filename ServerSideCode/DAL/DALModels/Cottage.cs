using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Cottage
{
    public int Code { get; set; }

    public string CottageName { get; set; }

    public int RegionCode { get; set; }

    public int TownCode { get; set; }

    public int NumOfBeds { get; set; }

    public int NumOfRooms { get; set; }

    public int Stars { get; set; }

    public int PriceToNight { get; set; }

    public string Description { get; set; }

    public int ConfirnCode { get; set; }

    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

    public virtual Region RegionCodeNavigation { get; set; }

    public virtual Town TownCodeNavigation { get; set; }
}
