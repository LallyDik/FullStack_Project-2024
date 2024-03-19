using DAL.DALApi;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class CottagePageD : ICottagePageD
{
    CottagesContext Context;

    public CottagePageD(CottagesContext context)
    {
        Context = context;
    }
    public void AddCottageAsync(Cottage cottagePage)
    {
        Context.Cottages.Add(cottagePage);
    }

    public bool CheckConfirmCode(int cottageCode, int confirmCode)
    {
        var cottage = Context.Cottages.Where(c => c.Code == cottageCode).FirstOrDefault();
        return cottage.ConfirmCode == confirmCode;
    }

    public void DeleteAsync(int cottageCode)
    {
        var cottage = Context.Cottages.Where(c => c.Code == cottageCode).FirstOrDefault();
        Context.Cottages.Remove(cottage);
    }

    public async Task<Cottage> GetCottageAsync(int cottageCode)
    {
        try
        {
            return Context.Cottages.Where(c => c.Code == cottageCode).FirstOrDefault();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
            return null;
        }
    }

    public void UpdateCottageAsync(Cottage cottagePage)
    {
        var cottage = Context.Cottages.Where(c => c.Code == cottagePage.Code).FirstOrDefault();
        Context.Cottages.Remove(cottage);
        Context.Cottages.Add(cottagePage);
    }

}
