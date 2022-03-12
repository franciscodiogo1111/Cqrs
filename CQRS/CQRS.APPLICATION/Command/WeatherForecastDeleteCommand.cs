using MediatR;

namespace CQRS.APPLICATION.Command
{
    public class WeatherForecastDeleteCommand : IRequest
    {
        public WeatherForecastDeleteCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
