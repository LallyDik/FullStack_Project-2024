using BLL.BLLModels;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLApi;

public interface ICottagePageRepoB
{
    Task<CottagePageB> GetCottageAsync(int cottageCode);
    Task<int> AddCottageAsync(CottagePageB cottagePage);
    Task<bool> UpdateCottageAsync(CottagePageB cottagePage, int confirmCode);
    Task<bool> DeleteAsync(int cottageCode, int confirmCode);
    bool CheckConfirmCode(int cottageCode, int confirmCode);
}
