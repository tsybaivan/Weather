using Newtonsoft.Json;

namespace Weather.Infrastructure.Model
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public double Deg { get; set; }
    }
}
