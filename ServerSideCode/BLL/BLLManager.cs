using BLL.BLLApi;
using BLL.BLLImplementation;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL;

public class BLLManager
{
    public ICottageTableRepoB CottageTableRepo { get; }
    public IRegionRepoB RegionRepo { get; }
    public ITownRepoB TownRepo { get; }
    public ICottagePageRepoB CottagePageRepo { get; }

    public BLLManager()
    {
        ServiceCollection services = new ServiceCollection();
        services.AddScoped<DALManager>();
        services.AddScoped<ICottageTableRepoB, CottageTableRepoB>();
        services.AddScoped< IRegionRepoB, RegionRepoB>();
        services.AddScoped< ITownRepoB, TownRepoB>();
        services.AddScoped<ICottagePageRepoB, CottagePageRepoB>();
        ServiceProvider servicesProvider = services.BuildServiceProvider();
        CottageTableRepo = servicesProvider.GetRequiredService<ICottageTableRepoB>();
        RegionRepo = servicesProvider.GetRequiredService<IRegionRepoB>();
        TownRepo = servicesProvider.GetRequiredService<ITownRepoB>();
        CottagePageRepo = servicesProvider.GetRequiredService<ICottagePageRepoB>();
    } 
}


