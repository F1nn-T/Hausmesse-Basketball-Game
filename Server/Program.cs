using Server.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Server.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddDbContext<GameContext>(opt =>
{
    //Only for development!
    opt.UseInMemoryDatabase("Game");
});

var app = builder.Build();

app.MapHub<GameHub>("game");
app.MapHub<HoopHub>("hoop");

app.Run();