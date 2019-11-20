using System;
using System.Threading.Tasks;
using Refit;
using Weather.Infrastructure.Model;
using Weather.Infrastructure.Services.Interfaces;

namespace Weather.Infrastructure.Services
{
    public class WeatherReceiverService : IWeatherReceiverService
    {
        private const string ServerUrl = "https://api.openweathermap.org";

        public async Task<WeatherData> GetWeatherDataAsync(string cityName)
        {
            var address = RestService.For<IOpenWeatherMapApi>(ServerUrl);
            WeatherData weather;
            try
            {
                weather = await address.GetWeatherDataAsync(cityName);
            }
            catch (ApiException exception)
            {
                throw new ArgumentException(nameof(cityName), exception);
            }
            return weather;
        }
    }
}
