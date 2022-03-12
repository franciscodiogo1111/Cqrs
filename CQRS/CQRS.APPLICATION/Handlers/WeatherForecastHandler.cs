using CQRS.APPLICATION.Command;
using CQRS.APPLICATION.Interface;
using CQRS.APPLICATION.Query;
using CQRS.APPLICATION.Response;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.APPICATION.Handlers
{
    public class WeatherForecastHandler : IRequestHandler<WeatherForecastQuery, WeatherForecastResponse>, IRequestHandler<WeatherForecastInsertCommand>, IRequestHandler<WeatherForecastUpdateCommand>, IRequestHandler<WeatherForecastDeleteCommand>
    {
        private readonly INoSqlRepository _NoSqlRepository;
        private readonly ISqlRepository _sqlRepository;
        public WeatherForecastHandler(INoSqlRepository NoSqlRepository, ISqlRepository sqlRepository) 
        {
            _NoSqlRepository = NoSqlRepository;
            _sqlRepository = sqlRepository;
        }

        public Task<WeatherForecastResponse> Handle(WeatherForecastQuery request, CancellationToken cancellationToken)
        {
            return _NoSqlRepository.GetAll(request);
        }
        public Task<Unit> Handle(WeatherForecastInsertCommand request, CancellationToken cancellationToken)
        {
            _sqlRepository.Insert(request);
            return Task.FromResult(Unit.Value);
        }

        public Task<Unit> Handle(WeatherForecastUpdateCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }

        public Task<Unit> Handle(WeatherForecastDeleteCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Unit.Value);
        }
    }
}
