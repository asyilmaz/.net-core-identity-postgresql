using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using NetCorePostgre.Application.Business;
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
        public static void ConfigureDatabase(this IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<PostgreSqlDbContext>();
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<PostgreSqlDbContext>().AddDefaultTokenProviders();
            services.AddSingleton(typeof(UserManager<User>));
        }

        public static void ConfigureBusinessClasses(this IServiceCollection services)
        {
            services.AddSingleton(typeof(UserBusiness));
        }
    }
}
