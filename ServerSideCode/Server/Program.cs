using BLL.BLLApi;
using BLL.BLLImplementation;
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





