using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCorePostgre.Application.Service;
using NetCorePostgre.Domain.Identity;
using NetCorePostgre.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCorePostgre.Application.Api
{
    public static class ServiceExtensions
    {
        internal static void ConfigureDatabase(this IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<PostgreSqlDbContext>();
        }

        internal static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<PostgreSqlDbContext>().AddDefaultTokenProviders();
            services.AddScoped(typeof(UserManager<User>));
        }

        internal static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped(typeof(UserService));
        }

        internal static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            //configuration.GetSection("JwtIssuerOptions")
        }
    }
}
