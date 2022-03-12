using CQRS.APPLICATION.Query;
using CQRS.APPLICATION.Response;
using System.Threading.Tasks;

namespace CQRS.APPLICATION.Interface
{
    public interface INoSqlRepository
    {
        Task<WeatherForecastResponse> GetAll(WeatherForecastQuery weatherForecastQuery);
    }
}
