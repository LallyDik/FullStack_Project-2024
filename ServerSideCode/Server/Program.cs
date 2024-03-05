using BLL.BLLApi;
using BLL.BLLImplementation;
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