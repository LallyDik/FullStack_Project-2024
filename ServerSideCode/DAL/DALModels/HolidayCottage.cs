using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class HolidayCottage
{
    public int Code { get; set; }

    public string CottageName { get; set; }

    public int AddressCode { get; set; }

    public int NumOfBeds { get; set; }

    public int NumOfRooms { get; set; }

    public int Stars { get; set; }

    public int PriceToNight { get; set; }

    public string Description { get; set; }

    public virtual Address AddressCodeNavigation { get; set; }

    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
}
