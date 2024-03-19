﻿using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

public interface IPictureRepoD
{
    Task<List<Picture>> GetPictureOfCottageAsync(int cottageCode);
}
