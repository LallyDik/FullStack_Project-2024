using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Region
{
    public int Code { get; set; }

    public string Rgion { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Town> Towns { get; set; } = new List<Town>();
}
