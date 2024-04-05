using ByteBattles.API.Extensions;
using ByteBattles.Application.Interfaces.Auth;
using ByteBattles.Application;
using ByteBattles.DataAccess;
using ByteBattles.DataAccess.Mappings;
using ByteBattlesAPI.Infrastructure.Authentication;


var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

var configuration = builder.Configuration;


services.AddEndpointsApiExplorer();

services.AddSwaggerGen();

services
    .AddPersistence(configuration)
    .AddApplication();
services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));

services.AddScoped<IJwtProvider, JwtProvider>();
services.AddScoped<IPasswordHasher, PasswordHasher>();

services.AddAutoMapper(typeof(DataBaseMappings));




var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddMappedEndpoints();

app.MapGet("get", () =>
{
    return Results.Ok("ok");
}).RequireAuthorization("AdminPolicy");

app.Run();
