using Common;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi;

public interface IPicturesRepo
{
    Task<List<Picture>> GetAllAsync(int cottageCode);
}
