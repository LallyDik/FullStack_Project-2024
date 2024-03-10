using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Cottage
{
    public int Code { get; set; }

    public string CottageName { get; set; }

    public int AddressCode { get; set; }

    public int NumOfBeds { get; set; }

    public int NumOfRooms { get; set; }

    public int Stars { get; set; }

    public int PriceToNight { get; set; }

<<<<<<<< HEAD:ServerSideCode/DAL/DALModels/Cottage.cs
    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
========
    public string Description { get; set; }

    public virtual Address AddressCodeNavigation { get; set; }
>>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497:ServerSideCode/DAL/DALModels/HolidayCottage.cs

    public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();
}
