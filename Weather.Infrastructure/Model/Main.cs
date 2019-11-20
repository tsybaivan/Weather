using Newtonsoft.Json;

namespace Weather.Infrastructure.Model
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
    }
}
