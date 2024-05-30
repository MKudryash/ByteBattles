using ByteBattles.Core.Interfaces.Repositories;
using ByteBattles.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;


namespace ByteBattles.DataAccess
{
    public static class PersistenceExtensions
    {
        public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<ByteBattlesDbContext>(options =>
            {
                options.UseNpgsql(configuration["ConnectionString:ByteBattlesDbStr"]);
            });

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
