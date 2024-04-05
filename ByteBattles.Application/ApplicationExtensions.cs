using ByteBattles.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ByteBattles.Application
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<UsersServices>();

            return services;
        }
    }
}
