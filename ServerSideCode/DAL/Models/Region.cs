using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Region
{
    public int Code { get; set; }

    public string Rgion { get; set; }

    public virtual ICollection<HolidayCottage> HolidayCottages { get; set; } = new List<HolidayCottage>();
}
