<<<<<<< HEAD:ServerSideCode/DAL/DALApi/IRegionRepoD.cs
﻿using DAL.DALModels;
=======
﻿using Common;
using DAL.DALModels;
>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497:ServerSideCode/DAL/DALApi/ITownRepo.cs
using DBAcsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

<<<<<<< HEAD:ServerSideCode/DAL/DALApi/IRegionRepoD.cs
public interface IRegionRepoD
{
    Task<List<Region>> GetAllRegionsAsync();
=======
public interface ITownRepo
{
    Task<List<Town>> GetAllAsync(int regionCode);
>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497:ServerSideCode/DAL/DALApi/ITownRepo.cs
}
