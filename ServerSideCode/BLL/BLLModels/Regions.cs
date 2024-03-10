using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels;

public class Regions
{
    public string RegionName { get; set; }
    public int RegionCode { get; set; }
    public Regions(string regionName, int regionCode)
    {
        this.RegionName = regionName;
        this.RegionCode = regionCode;   
    }
}
