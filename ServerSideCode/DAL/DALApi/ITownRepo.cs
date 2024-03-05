using Common;
using DAL.DALModels;
using DBAcsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

public interface ITownRepo
{
    Task<List<Town>> GetAllAsync(int regionCode);
}
