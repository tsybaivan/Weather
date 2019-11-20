using Newtonsoft.Json;

namespace Weather.Infrastructure.Model
{
    public class WeatherData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }
    }
}