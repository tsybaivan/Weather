using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weather.Infrastructure.Model;
using Weather.Infrastructure.Services.Interfaces;

namespace Weather.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherReceiverService _weatherReceiverService;

        public WeatherController(IWeatherReceiverService weatherReceiverService)
        {
            _weatherReceiverService = weatherReceiverService;
        }

        [HttpGet]
        public async Task<WeatherData> GetWeather([FromQuery] string cityName)
        {
            WeatherData weatherData = null;
            try
            {
                weatherData = await _weatherReceiverService.GetWeatherDataAsync(cityName);
            }
            catch (ArgumentException)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            return weatherData;
        }
    }
}
