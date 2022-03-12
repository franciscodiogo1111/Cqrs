using CQRS.APPLICATION.Interface;
using CQRS.DOMAIN.Entity;
using System.Threading.Tasks;

namespace CQRS.INFRA.Repository
{
    public class SqlRepository : ISqlRepository
    {
        public Task Delete(int id)
        {
            return Task.CompletedTask;
        }

        public Task Insert(WeatherForecast weatherForecast)
        {
            return Task.CompletedTask;
        }

        public Task Update(WeatherForecast weatherForecast)
        {
            return Task.CompletedTask;
        }
    }
}
