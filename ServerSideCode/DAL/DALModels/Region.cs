using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Region
{
    public int Code { get; set; }

    public string RegionName { get; set; }

    public virtual ICollection<Cottage> Cottages { get; set; } = new List<Cottage>();

    public virtual ICollection<Town> Towns { get; set; } = new List<Town>();
}
