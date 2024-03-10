using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Town
{
    public int Code { get; set; }

    public string TownName { get; set; }

    public int RegionCode { get; set; }

<<<<<<< HEAD
    public virtual ICollection<Cottage> Cottages { get; set; } = new List<Cottage>();
=======
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497

    public virtual Region RegionCodeNavigation { get; set; }
}
