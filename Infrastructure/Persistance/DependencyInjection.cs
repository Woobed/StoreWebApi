using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresistance(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["DefaultConnection"];
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IApplicationDbContext,ApplicationDbContext>();
            return services;
        }
    }
}
