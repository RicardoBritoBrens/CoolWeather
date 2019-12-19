using Newtonsoft.Json;

namespace CoolWeather.Models.OpenWeatherModels
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}
