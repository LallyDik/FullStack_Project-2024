using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class CottageParams:BaseQueryParams
{
    public int  RegionCode { get; set; }

    public int TownCode { get; set; }

    public int NumOfBeds { get; set; }

    public int Stars { get; set; }

    public int PriceToNight { get; set; }

}
