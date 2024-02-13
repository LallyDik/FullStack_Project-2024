using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HolidayCottage
{
    public string CottageName { get; set; }

    public int RegionCode { get; set; }

    public int TownCode { get; set; }

    public int AddressCode { get; set; }

    public int NumOfBeds { get; set; }

    public int NumOfRooms { get; set; }

    public int Stars { get; set; }

    public virtual Address AddressCodeNavigation { get; set; }

    public virtual Region RegionCodeNavigation { get; set; }

    public virtual Town TownCodeNavigation { get; set; }
}
