using System;
using System.Collections.Generic;

namespace DAL.DALModels;

public partial class Picture
{
    public int Code { get; set; }

    public string PicturesPath { get; set; }

    public int CottageCode { get; set; }

    public virtual Cottage CottageCodeNavigation { get; set; }
}
