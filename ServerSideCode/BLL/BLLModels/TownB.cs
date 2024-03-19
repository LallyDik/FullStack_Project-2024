using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels;

public class TownB
{
    public int TownCode { get; set; }
    public string TownName { get; set; }
    public TownB(int townCode, string townName)
    {
        TownCode = townCode;
        TownName = townName;
    }
}
