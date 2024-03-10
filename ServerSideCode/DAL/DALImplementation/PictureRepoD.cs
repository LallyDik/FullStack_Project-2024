using DAL.DALApi;
using DAL.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class PictureRepoD:IPictureRepoD
{
    CottagesContext Context;

    public PictureRepoD(CottagesContext context)
    {
        Context = context;
    }
    public async Task<List<Picture>> GetPictureOfCottageAsync(int cottageCode)
    {
        var pics = await Context.Pictures.ToListAsync();
        return pics.Where(p => p.CottageCode==cottageCode).ToList();
    }
}
