using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Town
{
    public int Code { get; set; }

    public string TownName { get; set; }

    public int RegionCode { get; set; }

    public virtual ICollection<Cottage> Cottages { get; set; } = new List<Cottage>();

    public virtual Region RegionCodeNavigation { get; set; }
}
