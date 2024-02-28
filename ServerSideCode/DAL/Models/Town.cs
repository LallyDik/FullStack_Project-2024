using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Town
{
    public int Code { get; set; }

    public string Town1 { get; set; }

    public int RegionCode { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Region RegionCodeNavigation { get; set; }
}
