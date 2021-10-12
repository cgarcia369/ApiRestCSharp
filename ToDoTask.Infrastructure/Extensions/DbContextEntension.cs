using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoTask.Infrastructure.Context;

namespace ToDoTask.Infrastructure.Extensions
{
    public static class DbContextEntension
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services,IConfiguration configuration)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("DefaultString"),serverVersion)
            );
            
            return services;
        }
        public static IServiceCollection AddAutoMapperExtension(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}