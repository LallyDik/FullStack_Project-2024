using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Town
{
    public int Code { get; set; }

    public string Town1 { get; set; }

    public virtual ICollection<HolidayCottage> HolidayCottages { get; set; } = new List<HolidayCottage>();
}
