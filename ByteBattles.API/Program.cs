using ByteBattles.API.Extensions;
using ByteBattles.Application.Interfaces.Auth;
using ByteBattles.Application;
using ByteBattles.DataAccess;
using ByteBattles.DataAccess.Mappings;
using ByteBattles.Infrastructure.Authentication;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.OpenApi.Models;
using ByteBattles.Apllication.Interfaces.Auth;
using ByteBattles.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

var configuration = builder.Configuration;

services.AddApiAuthentication(configuration);
services.AddAuthentication("Bearer");

services.AddEndpointsApiExplorer();

services.AddSwaggerGen(option =>
{
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });
});

services
    .AddPersistence(configuration)
    .AddApplication()
   .AddInfrastructure();
services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));


services.AddAutoMapper(typeof(DataBaseMappings));




var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddMappedEndpoints();

app.UseAuthentication();
app.UseAuthorization();

app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    HttpOnly = HttpOnlyPolicy.Always,
    Secure = CookieSecurePolicy.Always
});

app.Run();
