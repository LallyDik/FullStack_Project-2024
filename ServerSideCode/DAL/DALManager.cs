using DAL.DALImplementation;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public class DALManager
{
    public PictureRepoD Pictures { get; }  
    public RegionRepoD Regions { get;  }
    public TownRepoD Towns { get; }
    public CottageTableD Cottages { get; }
    public DALManager()
    {
        CottagesContext Context = new CottagesContext();
        Pictures = new PictureRepoD(Context);
        Regions = new RegionRepoD(Context);
        Towns = new TownRepoD(Context);
        Cottages = new CottageTableD(Context);
    }
}

