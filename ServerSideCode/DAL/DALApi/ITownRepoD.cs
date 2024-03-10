using DAL.DALModels;
using DBAcsess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

public interface ITownRepoD
{
    Task<List<Town>> GetAllTownsAsync(int regionCode);
}
