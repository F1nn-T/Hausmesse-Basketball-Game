using Server.Data.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddDbContext<GameContext>(opt =>
{
    //Only for development!
    opt.UseInMemoryDatabase("Game");
});

var app = builder.Build();

app.Run();