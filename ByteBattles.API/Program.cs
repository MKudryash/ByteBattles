using ByteBattles.DataAccess;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddEndpointsApiExplorer();

services.AddSwaggerGen();



builder.Services.AddDbContext<ByteBattlesDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("ByteBattlesDbStr")));



var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
