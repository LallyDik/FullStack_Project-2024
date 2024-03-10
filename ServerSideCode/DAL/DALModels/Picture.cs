using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Picture
{
<<<<<<< HEAD
    public int Code { get; set; }

    public string PicturesPath { get; set; }

    public int CottageCode { get; set; }

    public virtual Cottage CottageCodeNavigation { get; set; }
=======
    public int PictureCode { get; set; }

    public int CottgeCode { get; set; }

    public string PicturePath { get; set; }

    public virtual HolidayCottage CottgeCodeNavigation { get; set; }
>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497
}
