using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi
{
    public interface ICottagePageD
    {
        Task<Cottage> GetCottageAsync(int cottageCode);
        void AddCottageAsync(Cottage cottagePage);
        void UpdateCottageAsync(Cottage cottagePage);
        void DeleteAsync(int cottageCode);
        bool CheckConfirmCode(int cottageCode, int confirmCode);
    }
}
