using BLL.BLLModels;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.BLLApi.IRegionsRepo;

namespace BLL.BLLApi;

public interface IRegionsRepo
{
    Task<List<Regions>> GetAllRegionsAsync();

}
