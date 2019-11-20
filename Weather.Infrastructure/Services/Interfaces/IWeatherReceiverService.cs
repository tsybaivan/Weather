using System.Threading.Tasks;
using Weather.Infrastructure.Model;

namespace Weather.Infrastructure.Services.Interfaces
{
    public interface IWeatherReceiverService
    {
        Task<WeatherData> GetWeatherDataAsync(string cityName);
    }
}