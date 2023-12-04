using Microsoft.EntityFrameworkCore;
using StudentsManager.Server.Domain.Context;
using StudentsManager.Server.Services;
using StudentsManager.Server.Services.Interfaces;

namespace StudentsManager.Server.Configuration
{
    public static class AppServicesExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddTransient<IStudentsService, StudentsService>();
            services.AddTransient<IStudentsGroupsService, StudentsGroupsService>();

            return services;
        }
    }
}
