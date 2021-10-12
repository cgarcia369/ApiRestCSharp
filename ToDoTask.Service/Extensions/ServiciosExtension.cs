using System;
using Microsoft.Extensions.DependencyInjection;
using ToDoTask.Domain.Base;
using ToDoTask.Domain.Interfaces.Services;

namespace ToDoTask.Service.Extensions
{
    public static class ServiciosExtension
    {
        

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ITaskService,TaskService>();
            return services;
        }
    }
}