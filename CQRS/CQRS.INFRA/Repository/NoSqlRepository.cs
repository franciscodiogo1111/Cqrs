using CQRS.APPLICATION.Interface;
using CQRS.APPLICATION.Query;
using CQRS.APPLICATION.Response;
using System;
using System.Threading.Tasks;

namespace CQRS.INFRA.Repository
{
    public class NoSqlRepository : INoSqlRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public async Task<WeatherForecastResponse> GetAll(WeatherForecastQuery weatherForecastQuery)
        {
            var rng = new Random();
            return new WeatherForecastResponse() { Date = DateTime.Now, Summary = Summaries[rng.Next(Summaries.Length)], TemperatureC = rng.Next(-20, 55) };
        }
    }
}
