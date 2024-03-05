using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Picture
{
    public int PictureCode { get; set; }

    public int CottgeCode { get; set; }

    public string PicturePath { get; set; }

    public virtual HolidayCottage CottgeCodeNavigation { get; set; }
}
