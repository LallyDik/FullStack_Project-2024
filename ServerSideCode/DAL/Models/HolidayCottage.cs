using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HolidayCottage
{
    public string CottageName { get; set; }

    public int AddressCode { get; set; }

    public int NumOfBeds { get; set; }

    public int NumOfRooms { get; set; }

    public int Stars { get; set; }

    public int PriceToNight { get; set; }

    public virtual Address AddressCodeNavigation { get; set; }
}
