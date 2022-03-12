using CQRS.DOMAIN.Entity;
using MediatR;

namespace CQRS.APPLICATION.Command
{
    public class WeatherForecastInsertCommand : WeatherForecast, IRequest
    {
    }
}
