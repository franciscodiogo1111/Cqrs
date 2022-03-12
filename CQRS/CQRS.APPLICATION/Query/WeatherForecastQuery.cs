using CQRS.APPLICATION.Response;
using MediatR;

namespace CQRS.APPLICATION.Query
{
    public class WeatherForecastQuery : IRequest<WeatherForecastResponse>
    {
    }
}
