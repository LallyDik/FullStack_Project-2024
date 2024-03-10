using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Region
{
    public int Code { get; set; }

    public string RegionName { get; set; }

<<<<<<< HEAD
    public virtual ICollection<Cottage> Cottages { get; set; } = new List<Cottage>();
=======
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497

    public virtual ICollection<Town> Towns { get; set; } = new List<Town>();
}
