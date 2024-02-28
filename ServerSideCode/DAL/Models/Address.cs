using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Address
{
    public int Code { get; set; }

    public int RegionCode { get; set; }

    public int TownCode { get; set; }

    public string Street { get; set; }

    public int HouseNumber { get; set; }

    public virtual ICollection<HolidayCottage> HolidayCottages { get; set; } = new List<HolidayCottage>();

    public virtual Region RegionCodeNavigation { get; set; }

    public virtual Town TownCodeNavigation { get; set; }
}
