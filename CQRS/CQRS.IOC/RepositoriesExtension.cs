using CQRS.APPLICATION.Interface;
using CQRS.INFRA.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.IOC
{
    public static class RepositoriesExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<INoSqlRepository, NoSqlRepository>();
            services.AddTransient<ISqlRepository, SqlRepository>();
            return services;
        }
    }
}
