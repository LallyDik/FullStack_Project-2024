using BLL.BLLModels;
using Common;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLApi;

public interface ICottageTableRepoB
{
    Task<PagedList<CottageTableB>> GetCottageTable(CottageParams cottageParams);
}
