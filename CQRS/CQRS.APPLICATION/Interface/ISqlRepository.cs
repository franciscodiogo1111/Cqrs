using CQRS.DOMAIN.Entity;
using System.Threading.Tasks;

namespace CQRS.APPLICATION.Interface
{
    public interface ISqlRepository
    {
        Task Insert(WeatherForecast weatherForecast);
        Task Update(WeatherForecast weatherForecast);
        Task Delete(int id);
    }
}
