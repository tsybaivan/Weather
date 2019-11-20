using System.Threading.Tasks;
using Refit;
using Weather.Infrastructure.Model;

namespace Weather.Infrastructure.Services.Interfaces
{
    public interface IOpenWeatherMapApi
    {
        [Get("/data/2.5/weather?q={cityName}&units=metric&appid=9314d2ff9bcb366b09692f822461f535")]
        Task<WeatherData> GetWeatherDataAsync(string cityName);
    }
}