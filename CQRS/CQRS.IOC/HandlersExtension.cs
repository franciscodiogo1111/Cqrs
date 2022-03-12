using CQRS.APPICATION.Handlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.IOC
{
    public static class HandlersExtension
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services
                .AddMediatR(typeof(WeatherForecastHandler).Assembly);

            return services;
        }
    }
}
