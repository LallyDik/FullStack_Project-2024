using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Drawing.Drawing2D;
using BLL.BLLModels;
using DAL.DALModels;

namespace BLL.Mapping
{
    public class Mapping:Profile
    {
        public Mapping() {
            CreateMap<RegionB,Region>();
        }
    }
}
