using Microsoft.EntityFrameworkCore;
using StudentsManager.Server.Domain.Context;

namespace StudentsManager.Server.Configuration
{
    public static class MainContextExtensions
    {
        public static IServiceCollection AddMainContext(this IServiceCollection services, IConfiguration configuration)
        {
            string? connString = configuration.GetConnectionString("StudentsManagerStore");

            if (string.IsNullOrEmpty(connString))
                throw new ApplicationException("Problem encountered while extracting the connection string.");

            services.AddDbContext<MainContext>(options => options.UseSqlServer(connString));

            return services;
        }
    }
}
