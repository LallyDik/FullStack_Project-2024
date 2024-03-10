using BLL.BLLApi;
using BLL.BLLImplementation;
<<<<<<< HEAD
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors.Infrastructure;
using DAL.DALModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddScoped<IRegionRepoB, RegionRepoB>();
builder.Services.AddScoped<ITownRepoB, TownRepoB>();

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CORSPolicy",
//        builder =>
//        {
//            builder
//            .AllowAnyMethod()
//            .AllowAnyHeader()
//            .AllowAnyOrigin();
//        });
//});


DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("CottagesDB");
builder.Services.AddDbContext<CottagesContext>(options => options.UseSqlServer(connString));


var app = builder.Build();

//app.UseCors("CORSPolicy");
app.MapControllers();

app.Run();





=======
using DAL;
using DAL.DALModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

/*DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("AssistanceDB");*/


builder.Services.AddScoped<IRegionsRepo, RegionsRepo>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
>>>>>>> f525bc9ace61a3de7c665297e90bfade1d6e6497
