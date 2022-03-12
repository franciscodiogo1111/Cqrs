using CQRS.APPLICATION.Command;
using CQRS.APPLICATION.Query;
using CQRS.APPLICATION.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<WeatherForecastResponse> Get()
        {
            var weatherForecastQuery = new WeatherForecastQuery();
            return await _mediator.Send(weatherForecastQuery);
        }

        [HttpPost]
        public async Task Post([FromBody] WeatherForecastInsertCommand weatherForecastInsertCommand)
        {
            await _mediator.Send(weatherForecastInsertCommand);
        }

        [HttpPut]
        public async Task Put([FromBody] WeatherForecastUpdateCommand weatherForecastUpdateCommand)
        {
            await _mediator.Send(weatherForecastUpdateCommand);
        }


        [HttpDelete]
        public async Task Delete([FromQuery]int id)
        {
            await _mediator.Send(new WeatherForecastDeleteCommand(id));
        }
    }
}
