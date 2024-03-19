using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels;

public class RegionB
{
    public int RegionCode { get; set; }
    public string RegionName { get; set; }
    public RegionB(int regionCode, string regionName)
    {
        RegionCode = regionCode;
        RegionName = regionName;
    }
}
