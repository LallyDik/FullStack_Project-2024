using Common;
using DAL.DALApi;
using DAL.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation;

public class PictureRepo : IPicturesRepo
{
    HolidayContext Context;
    public PictureRepo(HolidayContext context)
    {
        Context = context;
    }
    public async Task<List<Picture>> GetAllAsync(int cottageCode)
    {
        var lst = await Context.Pictures.ToListAsync();
        return lst.Where(p => p.CottgeCode == cottageCode).ToList();
    }
}
